using System.Data.Entity;
using WhoseTurn.Common.Models;

namespace WhoseTurn.Common
{
    public class DbModel : DbContext
    {
        public DbModel() : base("name=WhoseTurn.Common.DbModel") { }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}