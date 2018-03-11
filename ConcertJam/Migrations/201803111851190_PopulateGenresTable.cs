namespace ConcertJam.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id, Name) Values (1, 'Jazz')");
            Sql("Insert Into Genres (Id, Name) Values (2, 'Hip Hop')");
            Sql("Insert Into Genres (Id, Name) Values (3, 'Kwaito')");
            Sql("Insert Into Genres (Id, Name) Values (4, 'Rhumba')");
        }

        public override void Down()
        {
            Sql("Delete from Genres where Id in (1,2,3,4)");
        }
    }
}
