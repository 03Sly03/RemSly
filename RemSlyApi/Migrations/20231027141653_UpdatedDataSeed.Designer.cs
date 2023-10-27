﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RemSlyApi.Datas;

#nullable disable

namespace RemSlyApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231027141653_UpdatedDataSeed")]
    partial class UpdatedDataSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClubMaterial", b =>
                {
                    b.Property<int>("ClubsId")
                        .HasColumnType("int");

                    b.Property<int>("MaterialsId")
                        .HasColumnType("int");

                    b.HasKey("ClubsId", "MaterialsId");

                    b.HasIndex("MaterialsId");

                    b.ToTable("ClubMaterial");
                });

            modelBuilder.Entity("RemSlyCore.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Is24h")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLadiesOnly")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Clubs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "43 Bd de Valmy, 59650 Villeneuve-d'Ascq",
                            Description = "Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                            Email = "Sunstar@club.com",
                            ImageUrl = "/images/club/Abbeville.jpg",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Sunstar Club",
                            OpeningHours = "10h00 - 20h00",
                            PhoneNumber = "0366333344",
                            PostalCode = "59650"
                        },
                        new
                        {
                            Id = 2,
                            Address = "292 Rue des Fusillés, 59493 Villeneuve-d'Ascq",
                            Description = "Bienvenu chez Cortex! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                            Email = "Cortex@club.com",
                            ImageUrl = "\"/images/club/Argentan.webp\"",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Cortex Club",
                            OpeningHours = "09h00 - 21h00",
                            PhoneNumber = "0320597941",
                            PostalCode = "59493"
                        },
                        new
                        {
                            Id = 3,
                            Address = "5 Pl. Pierre de Coubertin, 59790 Ronchin",
                            Description = "Bienvenu chez Cabana ! Adonnez-vous à votre activité sportive favorite chez Cabana Ladies et retrouvez la forme, sur nos appareils de fitness ou en suivant des cours collectifs.",
                            Email = "zumba@hotmail.com",
                            ImageUrl = "\"/images/club/Belgique.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = true,
                            Name = "Cabana Club",
                            OpeningHours = "08h00 - 22h00",
                            PhoneNumber = "0359613012",
                            PostalCode = "59790"
                        },
                        new
                        {
                            Id = 4,
                            Address = "124 Rue de Douai, 59000 Lille",
                            Description = "Bienvenu chez Kinetic ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                            Email = "Kinetic@outlook.com",
                            ImageUrl = "\"/images/club/Bessines.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Kinetic Club",
                            OpeningHours = "09h30 - 21h00",
                            PhoneNumber = "0320597941",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 5,
                            Address = "20 Rue des Meuniers, 59810 Lesquin",
                            Description = "Bienvenu chez Optimum 24/7 ! Besoin de vous entrainer à toute heure, nous disposons de la solution d'entraînement qui répond à vos besoins : Notre club vous accueille 24h/24h !",
                            Email = "Optimum@yahoo.com",
                            ImageUrl = "\"/images/club/Bruay.jpg\"",
                            Is24h = true,
                            IsLadiesOnly = false,
                            Name = "Optimum Club",
                            OpeningHours = "00h00 - 24h00",
                            PhoneNumber = "0771630955",
                            PostalCode = "59810"
                        },
                        new
                        {
                            Id = 6,
                            Address = "202 Rue Solférino, 59000 Lille",
                            Description = "Bienvenu chez Magellan ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                            Email = "Magellan@gmail.com",
                            ImageUrl = "\"/images/club/Cambrai.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Magellan Club",
                            OpeningHours = "06h00 - 23h00",
                            PhoneNumber = "0967583899",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 7,
                            Address = "4 Rue Professeur Langevin, 59000 Lille",
                            Description = "Bienvenu chez Pixel ! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                            Email = "Pixel@gmail.com",
                            ImageUrl = "\"/images/club/Courcelles.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Pixel Club",
                            OpeningHours = "07h00 - 22h00",
                            PhoneNumber = "0320309838",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 8,
                            Address = "3 bis Rue Edouard Delesalle, 59000 Lille",
                            Description = "Bienvenu chez Axion ! Quels que soient votre âge, votre niveau de pratique ou l'heure, nous serons à vos côtés pour répondre à vos besoins spécifiques.",
                            Email = "Axion@gmail.com",
                            ImageUrl = "\"/images/club/Dax.jpg\"",
                            Is24h = true,
                            IsLadiesOnly = false,
                            Name = "Axion Club",
                            OpeningHours = "06h00 - 23h00",
                            PhoneNumber = "0320550808",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 9,
                            Address = "124 Rue de Douai, 59000 Lille",
                            Description = "Bienvenu chez Panda ! Notre club dédié au femme est là pour vous accompagner dans votre remise en forme en proposant de nombreux cours collectifs.",
                            Email = "Panda@gmail.com",
                            ImageUrl = "\"/images/club/Jodigne.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = true,
                            Name = "Panda Club",
                            OpeningHours = "09h30 - 21h00",
                            PhoneNumber = "0320597941",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 10,
                            Address = "124 Rue de Douai, 59000 Lille",
                            Description = "Bienvenu chez Vita ! Notre club vous accompagnes 24h/24 tous les jours de la semaine, dans vos besoins sportifs pour être plein de vitalité !",
                            Email = "Vita@gmail.com",
                            ImageUrl = "\"/images/club/Pau.jpg\"",
                            Is24h = true,
                            IsLadiesOnly = false,
                            Name = "Vita Club",
                            OpeningHours = "00h00 - 24h00",
                            PhoneNumber = "0320597941",
                            PostalCode = "59000"
                        },
                        new
                        {
                            Id = 11,
                            Address = "62 Rue d'Iéna, 59000 Lille",
                            Description = "Bienvenu chez Luminous Club ! Venez découvrir le sport autrement dans notre salle sur les toits de la ville",
                            Email = "Luminous@gmail.com",
                            ImageUrl = "\"/images/club/Vesoul.jpg\"",
                            Is24h = false,
                            IsLadiesOnly = false,
                            Name = "Luminous Club",
                            OpeningHours = "10h00 - 17h00",
                            PhoneNumber = "0362859280",
                            PostalCode = "59000"
                        });
                });

            modelBuilder.Entity("RemSlyCore.Models.Commentary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("SessionId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SessionId");

                    b.HasIndex("UserId");

                    b.ToTable("Commentaries");
                });

            modelBuilder.Entity("RemSlyCore.Models.Material", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("RemSlyCore.Models.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CapacityMax")
                        .HasColumnType("int");

                    b.Property<int>("ClubId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsComplete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Schedules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CapacityMax = 10,
                            ClubId = 1,
                            ImageUrl = "/images/session/GroupClasses.jpg",
                            IsComplete = false,
                            Name = "Cours Collectifs Live",
                            Schedules = "10h00",
                            Score = 4
                        },
                        new
                        {
                            Id = 2,
                            CapacityMax = 20,
                            ClubId = 1,
                            ImageUrl = "/images/session/GroupClasses.jpg",
                            IsComplete = false,
                            Name = "Cours Collectifs Virtuel",
                            Schedules = "15h00",
                            Score = 3
                        },
                        new
                        {
                            Id = 3,
                            CapacityMax = 2,
                            ClubId = 1,
                            ImageUrl = "/images/session/PersonalTrainer.jpeg",
                            IsComplete = false,
                            Name = "Entraineur Personnel",
                            Schedules = "18h00",
                            Score = 5
                        },
                        new
                        {
                            Id = 5,
                            CapacityMax = 10,
                            ClubId = 2,
                            ImageUrl = "/images/session/GroupClasses.jpg",
                            IsComplete = false,
                            Name = "Cours Collectifs Live",
                            Schedules = "10h00",
                            Score = 4
                        },
                        new
                        {
                            Id = 6,
                            CapacityMax = 20,
                            ClubId = 2,
                            ImageUrl = "/images/session/GroupClasses.jpg",
                            IsComplete = false,
                            Name = "Cours Collectifs Virtuel",
                            Schedules = "15h00",
                            Score = 3
                        },
                        new
                        {
                            Id = 7,
                            CapacityMax = 2,
                            ClubId = 2,
                            ImageUrl = "/images/session/PersonalTrainer.jpeg",
                            IsComplete = false,
                            Name = "Entraineur Personnel",
                            Schedules = "18h00",
                            Score = 5
                        });
                });

            modelBuilder.Entity("RemSlyCore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AvatarUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ClubMaterial", b =>
                {
                    b.HasOne("RemSlyCore.Models.Club", null)
                        .WithMany()
                        .HasForeignKey("ClubsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemSlyCore.Models.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RemSlyCore.Models.Club", b =>
                {
                    b.HasOne("RemSlyCore.Models.User", null)
                        .WithMany("Favorites_Clubs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("RemSlyCore.Models.Commentary", b =>
                {
                    b.HasOne("RemSlyCore.Models.Session", "Session")
                        .WithMany("Comments")
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemSlyCore.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Session");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RemSlyCore.Models.Session", b =>
                {
                    b.HasOne("RemSlyCore.Models.Club", "Club")
                        .WithMany("Sessions")
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RemSlyCore.Models.User", null)
                        .WithMany("Favorites_Sessions")
                        .HasForeignKey("UserId");

                    b.Navigation("Club");
                });

            modelBuilder.Entity("RemSlyCore.Models.Club", b =>
                {
                    b.Navigation("Sessions");
                });

            modelBuilder.Entity("RemSlyCore.Models.Session", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("RemSlyCore.Models.User", b =>
                {
                    b.Navigation("Favorites_Clubs");

                    b.Navigation("Favorites_Sessions");
                });
#pragma warning restore 612, 618
        }
    }
}
