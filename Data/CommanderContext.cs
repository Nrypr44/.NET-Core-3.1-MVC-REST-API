using Microsoft.EntityFrameworkCore;
using project.Models;

namespace project.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {

        }
        
        //modelimizi veritabanına sunmak gibi düşünebiliriz. veritabanına maplemek
         public DbSet<Command> Commands { get; set; }
    }
}