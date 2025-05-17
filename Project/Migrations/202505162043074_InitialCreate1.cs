namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Products", "Image_url", c => c.String());
            AddColumn("dbo.Products", "Brand", c => c.String());
            DropColumn("dbo.Products", "Desctiption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Desctiption", c => c.String());
            DropColumn("dbo.Products", "Brand");
            DropColumn("dbo.Products", "Image_url");
            DropColumn("dbo.Products", "Description");
        }
    }
}
