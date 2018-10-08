namespace MovieBox.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "Category_CategoryID" });
            RenameColumn(table: "dbo.Movies", name: "Category_CategoryID", newName: "CategoryID");
            AlterColumn("dbo.Movies", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Movies", "CategoryID");
            AddForeignKey("dbo.Movies", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Movies", new[] { "CategoryID" });
            AlterColumn("dbo.Movies", "CategoryID", c => c.Int());
            RenameColumn(table: "dbo.Movies", name: "CategoryID", newName: "Category_CategoryID");
            CreateIndex("dbo.Movies", "Category_CategoryID");
            AddForeignKey("dbo.Movies", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
