using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Models
{
    public class Session
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        //public string? Description { get; set; }
        [Required]
        public string? Schedules { get; set; } // Possibilité de modifier en DateTime ?
        [Required]
        public int CapacityMax { get; set; }
        [Required]
        public bool IsComplete { get; set; }
        
        //public Dictionary<User> Notes {  get; set; }          // Voir pour la création
        
        public int Score { get; set; }
        public List<Commentary>? Comments { get; set; }
        //public List<User>? Users { get; set; }
    }
}
