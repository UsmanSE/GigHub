namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulatingGenresList : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Pop')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Country')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Rock')");
        }

        public override void Down()
        {
        }
    }
}
