using System.Data.Entity;
using WhoseTurn.Models;

namespace WhoseTurn
{
    public class DbModelInitializer : DropCreateDatabaseIfModelChanges<DbModel>
    {
        protected override void Seed(DbModel context)
        {
            var katie = new Person {Name = "Katie"};
            var chris = new Person {Name = "Chris"};
            context.People.AddRange(new []{ katie, chris });

            var tasks = new[]
            {
                new Task { Name = "Dinner", TurnPerson = katie}, 
                new Task { Name = "Laundry", TurnPerson = chris}, 
                new Task { Name = "Dishes", TurnPerson = chris}
            };
            context.Tasks.AddRange(tasks);
        }
    }
}