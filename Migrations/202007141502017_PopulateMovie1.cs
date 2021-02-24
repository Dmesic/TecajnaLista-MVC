namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovie1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock)" +
                "VALUES             ('Hangover','Comedy','2015/12/17','2020/12/17',2)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock)" +
                "VALUES             ('Die Hard','Action','2010/12/17','2020/12/17',3)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock)" +
                "VALUES             ('The Terminator','Action','2009/01/13','2020/12/17',23)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock)" +
                "VALUES             ('Toy Story','Family','2018/10/17','2020/12/17',1)");
            Sql("INSERT INTO Movies (Name,Genre,ReleaseDate,DateAdded,NumberInStock)" +
                "VALUES             ('Titanic','Romance','2012/12/12','2020/12/17',5)");
        }
        
        public override void Down()
        {
        }
    }
}
