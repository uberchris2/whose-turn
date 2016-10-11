using WhoseTurn.Common.Models;

namespace WhoseTurn
{
    using System.Data.Entity;

    public class DbModel : DbContext
    {
        public DbModel() : base("name=DbModel") { }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
    }
}