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
            var katie = new Person { Id = 1, Name = "Katie" };
            var chris = new Person { Id = 2, Name = "Chris" };
            context.People.AddOrUpdate(katie, chris);

            var tasks = new[]
            {
                new Task { Id = 1, Name = "Dinner", TurnPersonId = 2},
                new Task { Id = 2, Name = "Laundry", TurnPersonId = 2},
                new Task { Id = 3, Name = "Dishes", TurnPersonId = 2}
            };
            context.Tasks.AddOrUpdate(tasks);
        }
    }
}
