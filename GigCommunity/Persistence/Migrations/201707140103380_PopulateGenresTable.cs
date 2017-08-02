namespace GigCommunity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (Id, Name) VALUES (1, 'Blues')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (2, 'Country')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (3, 'Gospel')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (4, 'Jazz')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (5, 'Rap')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (6, 'Reggae')");
            Sql("INSERT INTO GENRES (Id, Name) VALUES (7, 'Rock')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id in (1, 2, 3, 4, 5, 6, 7)");
        }
    }
}
