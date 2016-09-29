using WhoseTurn.Models;

namespace WhoseTurn.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DbModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WhoseTurn.DbModel";
        }

        protected override void Seed(DbModel context)
        {
            var katie = new Person { Name = "Katie" };
            var chris = new Person { Name = "Chris" };
            context.People.AddOrUpdate(katie, chris);

            var tasks = new[]
            {
                new Task { Name = "Dinner", TurnPerson = katie},
                new Task { Name = "Laundry", TurnPerson = chris},
                new Task { Name = "Dishes", TurnPerson = chris}
            };
            context.Tasks.AddOrUpdate(tasks);
        }
    }
}
