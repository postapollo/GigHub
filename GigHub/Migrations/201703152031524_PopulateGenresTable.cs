namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Jazz')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Blues')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Rock')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Country')");
        }
        
        public override void Down() //when we downgrade the database, can downgrade with any code first implementation. 
            //good practice to update downgrade when updating 
        {   //downgrade undoes the update operations 
            Sql("DELETE FROM Genres WHERE Id IN (1, 2, 3, 4)");
        }
    }
}
