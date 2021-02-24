namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembership : DbMigration
    {
        public override void Up()
        {
            Sql("update MembershipTypes SET Name= 'Pay as you go' WHERE Id = 1");
            Sql("update MembershipTypes SET Name= 'Monthly' WHERE Id = 2");
        }

        public override void Down()
        {
        }
    }
}
