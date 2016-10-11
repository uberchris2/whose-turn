using System.Data.Entity.Migrations;

namespace WhoseTurn.Common.Migrations
{
    public partial class AddGroups : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.People", "Group_Id", c => c.Int(false));
            AddColumn("dbo.Tasks", "Group_Id", c => c.Int(false));
            CreateIndex("dbo.People", "Group_Id");
            CreateIndex("dbo.Tasks", "Group_Id");
            AddForeignKey("dbo.People", "Group_Id", "dbo.Groups", "Id");
            AddForeignKey("dbo.Tasks", "Group_Id", "dbo.Groups", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.People", "Group_Id", "dbo.Groups");
            DropIndex("dbo.Tasks", new[] { "Group_Id" });
            DropIndex("dbo.People", new[] { "Group_Id" });
            DropColumn("dbo.Tasks", "Group_Id");
            DropColumn("dbo.People", "Group_Id");
            DropTable("dbo.Groups");
        }
    }
}
