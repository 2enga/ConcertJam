namespace ConcertJam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeyPropertiesToShow : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Shows", name: "Artist_Id", newName: "ArtistId");
            RenameColumn(table: "dbo.Shows", name: "Genre_Id", newName: "GenreId");
            RenameIndex(table: "dbo.Shows", name: "IX_Artist_Id", newName: "IX_ArtistId");
            RenameIndex(table: "dbo.Shows", name: "IX_Genre_Id", newName: "IX_GenreId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Shows", name: "IX_GenreId", newName: "IX_Genre_Id");
            RenameIndex(table: "dbo.Shows", name: "IX_ArtistId", newName: "IX_Artist_Id");
            RenameColumn(table: "dbo.Shows", name: "GenreId", newName: "Genre_Id");
            RenameColumn(table: "dbo.Shows", name: "ArtistId", newName: "Artist_Id");
        }
    }
}
