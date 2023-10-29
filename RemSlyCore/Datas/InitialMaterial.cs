using RemSlyCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Datas
{
    public class InitialMaterial
    {
        public static readonly List<Material> materialsInit = new List<Material>()
        {
            new Material()
            { Id = 1, Name ="Bancs de musculation" },
            new Material()
            { Id = 2, Name ="Barre fixe" },
            new Material()
            { Id = 3, Name ="Haltères " },
            new Material()
            { Id = 4, Name ="Cage à squat" },
            new Material()
            { Id = 5, Name ="Presse à cuisse" },
            new Material()
            { Id = 6, Name ="Machine à poulie" },
            new Material()
            { Id = 7, Name ="Vélo" },
            new Material()
            { Id = 8, Name ="Vélo elliptique" },
            new Material()
            { Id = 9, Name ="Tapis de course" },
            new Material()
            { Id = 10, Name ="Rameur" },
            new Material()
            { Id = 11, Name ="Kettlebell" },
            new Material()
            { Id = 12, Name ="Elastique" },
            new Material()
            { Id = 13, Name ="Corde à sauter" },
            new Material()
            { Id = 14, Name ="Tapis de sol" },
        };
    }
}
