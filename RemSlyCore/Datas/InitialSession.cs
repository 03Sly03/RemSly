using RemSlyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Datas
{
    public static class InitialSession
    {
        public static readonly List<Session> sessionInit = new List<Session>()
        {

        #region Sessions pour le Club 1 
            new Session()
            {
                Id=1,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 1,
            },

            new Session()
            {
                Id=2,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 1,
            },

            new Session()
            {
                Id=3,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/Images/Session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 1,
            },
            #endregion

        #region Sessions pour le Club 2
            new Session()
            {
                Id=4,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 2,
            },

            new Session()
            {
                Id=5,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 2,
            },

            new Session()
            {
                Id=6,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 2,
            },
#endregion

        #region Sessions pour le Club 3 

            new Session()
            {
                Id=7,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 3,
            },

            new Session()
            {
                Id=8,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 3,
            },

            new Session()
            {
                Id=9,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/Images/Session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 3,
            },
            #endregion

        #region Sessions pour le Club 4
            new Session()
            {
                Id=10,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 4,
            },

            new Session()
            {
                Id=11,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 4,
            },

            new Session()
            {
                Id=12,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 4,
            },
#endregion

        #region Sessions pour le Club 5
            new Session()
            {
                Id=13,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 5,
            },

            new Session()
            {
                Id=14,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 5,
            },

            new Session()
            {
                Id=15,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 5,
            },
#endregion

        #region Sessions pour le Club 6
            new Session()
            {
                Id=16,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 6,
            },

            new Session()
            {
                Id=17,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 6,
            },

            new Session()
            {
                Id=18,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 6,
            },
#endregion
        
        #region Sessions pour le Club 7
            new Session()
            {
                Id=19,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 7,
            },

            new Session()
            {
                Id=20,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 7,
            },

            new Session()
            {
                Id=21,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 7,
            },
#endregion

        #region Sessions pour le Club 8

            new Session()
            {
                Id=22,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 8,
            },

            new Session()
            {
                Id=23,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/Images/Session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 8,
            },

            new Session()
            {
                Id=24,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/Images/Session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 8,
            },
            #endregion

        #region Sessions pour le Club 9
            new Session()
            {
                Id=25,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 9,
            },

            new Session()
            {
                Id=26,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 9,
            },

            new Session()
            {
                Id=27,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 9,
            },
#endregion

        #region Sessions pour le Club 10
            new Session()
            {
                Id=28,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 10,
            },

            new Session()
            {
                Id=29,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 10,
            },

            new Session()
            {
                Id=30,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 10,
            },
#endregion

        #region Sessions pour le Club 11
            new Session()
            {
                Id=31,
                Name="Cours Collectifs Live",
                CapacityMax = 10,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 4,
                Schedules = "10h00",
                ClubId = 11,
            },

            new Session()
            {
                Id=32,
                Name="Cours Collectifs Virtuel",
                CapacityMax = 20,
                ImageUrl="/images/session/GroupClasses.jpg",
                IsComplete= false,
                Score = 3,
                Schedules = "15h00",
                ClubId = 11,
            },

            new Session()
            {
                Id=33,
                Name="Entraineur Personnel",
                CapacityMax = 2,
                ImageUrl="/images/session/PersonalTrainer.jpeg",
                IsComplete= false,
                Score = 5,
                Schedules = "18h00",
                ClubId = 11,
            },
#endregion
        };
    }
}
