namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Hangover', 1, '2009/11/6', '2016/5/4', 5)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Die Hard', 2, '2012/08/7', '2016/5/4', 12)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('The Terminator', 2, '2015/03/12', '2016/5/4', 9)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Toy Story', 3, '2005/05/16', '2016/5/4', 30)");
            Sql("INSERT INTO Movies (Name, Genre_Id, ReleaseDate, DateAdded, NumberInStock) VALUES ('Titanic', 4, '1998/12/8', '2016/5/4', 24)");
        }
        
        public override void Down()
        {
        }
    }
}
