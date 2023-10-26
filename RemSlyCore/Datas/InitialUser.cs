using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemSlyCore.Models;

namespace RemSlyCore.Datas
{
    public static class InitialUser
    {
        public static readonly List<User> UserInit = new List<User>()
        {
            new User
            {
                Id = 1, FirstName = "Christophe", LastName = "Chauveau", Gender = Gender.Male, AvatarUrl = "/images/avatar/Christophe.jpg" , Address = "7 rue de la Paix, 59000 Lille", PostalCode = "59000", Email = "christophe@gmail.com" , PassWord = "christophe123", PhoneNumber = "0607019001" , IsAdmin = true
            },
            new User
            {
                Id = 2, FirstName = "Anthony", LastName = "Boisselet", Gender = Gender.Male, AvatarUrl = "/images/avatar/Anthony.jpg" , Address = "41 rue de Calais, 59130 Lambersart", PostalCode = "59130", Email = "anthony@gmail.com" , PassWord = "anthony123", PhoneNumber = "0647911071" , IsAdmin = false
            },
            new User
            {
                Id = 3, FirstName = "Thomas", LastName = "Lavaud", Gender = Gender.Male, AvatarUrl = "/images/avatar/Thomas.jpg" , Address = "33 rue des Fleurs, 59650 Villeneuve d'Ascq", PostalCode = "59650", Email = "thomas@gmail.com" , PassWord = "thomas123", PhoneNumber = "0741810974" , IsAdmin = false
            },
            new User
            {
                Id = 4, FirstName = "Laura", LastName = "Delcroix", Gender = Gender.Female, AvatarUrl = "/images/trainer/LauraTrainer.png" , Address = "9 rue des plantes, 59200 Tourcoing", PostalCode = "59200", Email = "laura@gmail.com" , PassWord = "laura123", PhoneNumber = "0644810904" , IsAdmin = false
            },
            new User
            {
                Id = 5, FirstName = "Amelie", LastName = "Duchemin", Gender = Gender.Female, AvatarUrl = "/images/trainer/AmelieTrainer.jpg" , Address = "14 avenue de Dunkerque, 59160 Lille", PostalCode = "59160", Email = "amelie@gmail.com" , PassWord = "amelie123", PhoneNumber = "0709749425" , IsAdmin = false
            },

        };

    }
}
