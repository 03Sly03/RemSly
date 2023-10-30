using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemSlyCore.Models
{
    public class Commentary
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Content { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int SessionId { get; set; }
        public Session? Session { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
