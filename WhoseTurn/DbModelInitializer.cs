using System.Data.Entity;
using WhoseTurn.Models;
using System.Linq;

namespace WhoseTurn
{
    public class DbModelInitializer : DropCreateDatabaseIfModelChanges<DbModel>
    {
        protected override void Seed(DbModel context)
        {
            if (context.People.Any()) return;

            context.People.Add(new Person {Name = "Katie"});
            context.People.Add(new Person {Name = "Chris"});
        }
    }
}