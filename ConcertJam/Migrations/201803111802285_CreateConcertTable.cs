namespace ConcertJam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateConcertTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Artist_Id = c.String(maxLength: 128),
                        Genre_Id = c.Byte(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Artist_Id)
                .ForeignKey("dbo.Genres", t => t.Genre_Id)
                .Index(t => t.Artist_Id)
                .Index(t => t.Genre_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Shows", "Artist_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Shows", new[] { "Genre_Id" });
            DropIndex("dbo.Shows", new[] { "Artist_Id" });
            DropTable("dbo.Shows");
            DropTable("dbo.Genres");
        }
    }
}
