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
            #region Club de 1 à 5
            new Club
            {
                Id = 1,
                Name = "Sunstar Club",
                Address = "43 Bd de Valmy, 59650 Villeneuve-d'Ascq",
                PostalCode = "59650",
                PhoneNumber = "0366333344" ,
                Email = "Sunstar@club.com" ,
                OpeningHours = "10h00 - 20h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Sunstar! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                ImageUrl ="/Images/Club/Abbeville.jpg",
            },

            new Club
            {
                Id = 2,
                Name = "Cortex Club",
                Address = "292 Rue des Fusillés, 59493 Villeneuve-d'Ascq",
                PostalCode = "59493",
                PhoneNumber = "0320597941" ,
                Email = "Cortex@club.com" ,
                OpeningHours = "09h00 - 21h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Cortex! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                ImageUrl ="/Images/Club/Argentan.webp",
            },

            new Club
            {
                Id = 3,
                Name = "Cabana Club",
                Address = "5 Pl. Pierre de Coubertin, 59790 Ronchin",
                PostalCode = "59790",
                PhoneNumber = "0359613012" ,
                Email = "zumba@hotmail.com" ,
                OpeningHours = "08h00 - 22h00",
                IsLadiesOnly = true,
                Is24h = false,
                Description ="Bienvenu chez Cabana ! Adonnez-vous à votre activité sportive favorite chez Cabana Ladies et retrouvez la forme, sur nos appareils de fitness ou en suivant des cours collectifs.",
                ImageUrl="/Images/Club/Belgique.jpg",
            },
            new Club
            {
                Id = 4,
                Name = "Kinetic Club",
                Address = "124 Rue de Douai, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320597941" ,
                Email = "Kinetic@outlook.com" ,
                OpeningHours = "09h30 - 21h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Kinetic ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                ImageUrl="/Images/Club/Bessines.jpg",
            },

            new Club
            {
                Id = 5,
                Name = "Optimum Club",
                Address = "20 Rue des Meuniers, 59810 Lesquin",
                PostalCode = "59810",
                PhoneNumber = "0771630955" ,
                Email = "Optimum@yahoo.com" ,
                OpeningHours = "00h00 - 24h00",
                IsLadiesOnly = false,
                Is24h = true,
                Description ="Bienvenu chez Optimum 24/7 ! Besoin de vous entrainer à toute heure, nous disposons de la solution d'entraînement qui répond à vos besoins : Notre club vous accueille 24h/24h !",
                ImageUrl="/Images/Club/Bruay.jpg",
            },
            #endregion

            #region Club de 6 à 10
            new Club
            {
                Id = 6,
                Name = "Magellan Club",
                Address = "202 Rue Solférino, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0967583899" ,
                Email = "Magellan@gmail.com" ,
                OpeningHours = "06h00 - 23h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Magellan ! Notre club est équipé d'une large gamme d'appareils de fitness et propose de nombreux cours collectifs.",
                ImageUrl="/Images/Club/Cambrai.jpg",
            },

            new Club
            {
                Id = 7,
                Name = "Pixel Club",
                Address = "4 Rue Professeur Langevin, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320309838" ,
                Email = "Pixel@gmail.com" ,
                OpeningHours = "07h00 - 22h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Pixel ! Nous disposons d'une large gamme d'appareils de fitness et de cours collectifs. Passez nous voir au club pour choisir l'activité sportive qui vous convient le mieux.",
                ImageUrl="/Images/Club/Courcelles.jpg",
            },

            new Club
            {
                Id = 8,
                Name = "Axion Club",
                Address = "3 bis Rue Edouard Delesalle, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320550808" ,
                Email = "Axion@gmail.com" ,
                OpeningHours = "06h00 - 23h00",
                IsLadiesOnly = false,
                Is24h = true,
                Description ="Bienvenu chez Axion ! Quels que soient votre âge, votre niveau de pratique ou l'heure, nous serons à vos côtés pour répondre à vos besoins spécifiques.",
                ImageUrl="/Images/Club/Dax.jpg",
            },

            new Club
            {
                Id = 9,
                Name = "Panda Club",
                Address = "124 Rue de Douai, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320597941" ,
                Email = "Panda@gmail.com" ,
                OpeningHours = "09h30 - 21h00",
                IsLadiesOnly = true,
                Is24h = false,
                Description ="Bienvenu chez Panda ! Notre club dédié au femme est là pour vous accompagner dans votre remise en forme en proposant de nombreux cours collectifs.",
                ImageUrl="/Images/Club/Jodoigne.jpeg",
            },

            new Club
            {
                Id = 10,
                Name = "Vita Club",
                Address = "124 Rue de Douai, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0320597941" ,
                Email = "Vita@gmail.com" ,
                OpeningHours = "00h00 - 24h00",
                IsLadiesOnly = false,
                Is24h = true,
                Description ="Bienvenu chez Vita ! Notre club vous accompagnes 24h/24 tous les jours de la semaine, dans vos besoins sportifs pour être plein de vitalité !",
                ImageUrl="/Images/Club/Pau.jpg",
            },
            #endregion

            new Club
            {
                Id = 11,
                Name = "Luminous Club",
                Address = "62 Rue d'Iéna, 59000 Lille",
                PostalCode = "59000",
                PhoneNumber = "0362859280" ,
                Email = "Luminous@gmail.com" ,
                OpeningHours = "10h00 - 17h00",
                IsLadiesOnly = false,
                Is24h = false,
                Description ="Bienvenu chez Luminous Club ! Venez découvrir le sport autrement dans notre salle sur les toits de la ville",
                ImageUrl="/Images/Club/Vesoul.jpg",
            },
        };
    }
}
