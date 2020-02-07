using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMonster.Models
{
    public class Monster
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        public string Called { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Type { get; set; }
        [Display(Name = "Max HP")]
        [Range(10, 300)]
        [Required]
        public int Hp { get; set; }
        [Range(10, 300)]
        [Required]
        public int Damage { get; set; }
        [Range(1, 100)]
        [Required]
        public int Defense { get; set; }
    }
}
