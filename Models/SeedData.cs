using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMonster.Data;
using System;
using System.Linq;

namespace MvcMonster.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMonsterContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMonsterContext>>()))
            {
                if (context.Monster.Any())
                {
                    return;
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        Called = "Gor-Gor",
                        Type = "Kobald",
                        Hp = 21,
                        Damage = 2
                    },

                    new Monster
                    {
                        Called = "Guindey",
                        Type = "Gnoll",
                        Hp = 33,
                        Damage = 5
                    },

                    new Monster
                    {
                        Called = "Slugeth",
                        Type = "Orc",
                        Hp = 45,
                        Damage = 6
                    },

                    new Monster
                    {
                        Called = "Hazdreth",
                        Type = "Dragon",
                        Hp = 99,
                        Damage = 12
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
