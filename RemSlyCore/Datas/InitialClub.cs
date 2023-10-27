using RemSlyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Datas
{
    public class InitialClub
    {
        public static readonly List<Club> clubInit = new List<Club>()
        {
            new Club
            {
                Id = 1,
                Name = "Sunstar Club",
                Address = "43 Bd de Valmy, 59650 Villeneuve-d'Ascq",
                PostalCode = "59650",
                PhoneNumber = "0366333344" ,
                Email = "anthony@gmail.com" ,
                OpeningHours = "10h00 - 20h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                ImageUrl ="",
                Materials = new List<Material>(),
                Sessions = new List<Session>(),

            },

            new Club
            {
                Id = 2,
                Name = "Sunstar Club",
                Address = "43 Bd de Valmy, 59650 Villeneuve-d'Ascq",
                PostalCode = "59650",
                PhoneNumber = "0366333344" ,
                Email = "anthony@gmail.com" ,
                OpeningHours = "10h00 - 20h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                ImageUrl ="",
                Materials = new List<Material>(),
                Sessions = new List<Session>(),

            },

            new Club
            {
                Id = 3,
                Name = "Cabana Club",
                Address = "5 Pl. Pierre de Coubertin, 59790 Ronchin",
                PostalCode = "59790",
                PhoneNumber = "0359613012" ,
                Email = "zumba@gmail.com" ,
                OpeningHours = "08h00 - 22h00",
                IsLadiesOnly = true,
                Is24h = false,
                Description ="Bienvenu chez Cabana ! Quels que soient votre âge, votre niveau de pratique et votre objectif forme, nous disposons de la solution d'entraînement qui répond à vos besoins spécifiques.",
                ImageUrl="",
                Materials = new List<Material>(),
                Sessions = new List<Session>(),

            },
            new Club 
            {
                Id = 3,
                Name = "Kinetic Club",
                Address = "124 Rue de Douai, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320597941" ,
                Email = "zumba@gmail.com" ,
                OpeningHours = "09h30 - 21h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Kinetic ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                ImageUrl="",
                Materials = new List<Material>(),
                Sessions = new List<Session>(),

            },
        };
    }
}
