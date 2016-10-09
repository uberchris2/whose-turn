namespace WhoseTurn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroupId : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.People", "Group_Id", "dbo.Groups");
            DropIndex("dbo.People", new[] { "Group_Id" });
            RenameColumn(table: "dbo.People", name: "Group_Id", newName: "GroupId");
            AlterColumn("dbo.People", "GroupId", c => c.Int(nullable: false));
            CreateIndex("dbo.People", "GroupId");
            AddForeignKey("dbo.People", "GroupId", "dbo.Groups", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.People", "GroupId", "dbo.Groups");
            DropIndex("dbo.People", new[] { "GroupId" });
            AlterColumn("dbo.People", "GroupId", c => c.Int());
            RenameColumn(table: "dbo.People", name: "GroupId", newName: "Group_Id");
            CreateIndex("dbo.People", "Group_Id");
            AddForeignKey("dbo.People", "Group_Id", "dbo.Groups", "Id");
        }
    }
}
