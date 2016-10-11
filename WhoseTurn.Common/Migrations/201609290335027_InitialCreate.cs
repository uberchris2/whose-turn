using System.Data.Entity.Migrations;

namespace WhoseTurn.Common.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TurnPersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.TurnPersonId, cascadeDelete: true)
                .Index(t => t.TurnPersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "TurnPersonId", "dbo.People");
            DropIndex("dbo.Tasks", new[] { "TurnPersonId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.People");
        }
    }
}
