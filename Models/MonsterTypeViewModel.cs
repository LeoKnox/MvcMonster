using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMonster.Models
{
    public class MonsterTypeViewModel
    {
        public List<Monster> Monsters { get; set; }
        public SelectList Types { get; set; }
        public string MonsterType { get; set; }
        public string SearchString { get; set; }
    }
}
