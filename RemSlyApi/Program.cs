using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using RemSlyApi.Datas;
using RemSlyApi.Helpers;
using RemSlyApi.Repositories;
using RemSlyCore.Models;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IRepository<Club>, ClubRepository>();
builder.Services.AddScoped<IRepository<Session>, SessionRepository>();
builder.Services.AddScoped<IRepository<Commentary>, CommentaryRepository>();
builder.Services.AddScoped<IRepository<User>, UserRepository>();
builder.Services.AddControllers().AddJsonOptions(x =>
                            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

var appSettingsSection = builder.Configuration.GetSection(nameof(AppSettings));
// on l'enregistre dans nos services (utile pour la partie login/register)
builder.Services.Configure<AppSettings>(appSettingsSection); // => donne un IOption<AppSettings> dans le conteneur de dépendances
                                                             // on récupère la section pour program.cs
AppSettings appSettings = appSettingsSection.Get<AppSettings>();

// on récupère la clé et on l'encode
var key = Encoding.ASCII.GetBytes(appSettings.SecretKey!);

// Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true, // utilisation d'une clé cryptée pour la sécurité du token
            IssuerSigningKey = new SymmetricSecurityKey(key), // clé cryptée en elle même
            ValidateLifetime = true, // vérification du temps d'expiration du Token
            ValidateAudience = true, // vérification de l'audience du token
            ValidAudience = appSettings.ValidAudience, // l'audience
            ValidateIssuer = true, // vérification du donneur du token
            ValidIssuer = appSettings.ValidIssuer, // le donneur
            ClockSkew = TimeSpan.Zero // décallage possible de l'expiration du token
        };
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options =>
{
    options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
});

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
