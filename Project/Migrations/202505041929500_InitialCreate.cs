namespace Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Favourites",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Hidden_Product",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                        Product_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Options",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Question_Id = c.Int(nullable: false),
                        Text = c.String(),
                        Weight = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Desctiption = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Category = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Questions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Survey_ID = c.Int(nullable: false),
                        Text = c.String(),
                        Question_Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Surveys",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Is_Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users_answer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        User_ID = c.Int(nullable: false),
                        Option_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password_Hash = c.String(),
                        Name = c.String(),
                        Created_At = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Users_answer");
            DropTable("dbo.Surveys");
            DropTable("dbo.Questions");
            DropTable("dbo.Products");
            DropTable("dbo.Options");
            DropTable("dbo.Hidden_Product");
            DropTable("dbo.Favourites");
        }
    }
}
