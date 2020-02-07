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
        public string Called { get; set; }
        public string Type { get; set; }
        [Display(Name = "Max HP")]
        public int Hp { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
    }
}
