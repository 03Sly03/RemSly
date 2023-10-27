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
                Name = "Antho Club", 
                Address = "rue Douchet", 
                PostalCode = "59000", 
                PhoneNumber = "0606060606" , 
                Email = "anthony@gmail.com" , 
                OpeningHours = "10h / 20h", 
                IsLadiesOnly = false, 
                Is24h = false
            },
            new Club
            {
                Id = 2, 
                Name = "Zumba Club", 
                Address = "rue Hugo", 
                PostalCode = "62000", 
                PhoneNumber = "0707070707" , 
                Email = "zumba@gmail.com" , 
                OpeningHours = "20h / 2h", 
                IsLadiesOnly = true, 
                Is24h = true
            },
        };
    }
}
