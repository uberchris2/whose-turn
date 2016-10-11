using System.Data.Entity.Migrations;

namespace WhoseTurn.Common.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DbModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WhoseTurn.DbModel";
        }

        protected override void Seed(DbModel context)
        {
        }
    }
}
