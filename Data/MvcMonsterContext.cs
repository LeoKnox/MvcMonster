using Microsoft.EntityFrameworkCore;
using MvcMonster.Models;

namespace MvcMonster.Data
{
    public class MvcMonsterContext : DbContext
    {
        public MvcMonsterContext(DbContextOptions<MvcMonsterContext> options)
            : base(options)
        {
        }

        public DbSet<Monster> Monster { get; set; }
    }
}