namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTecajs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tecajs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Valuta = c.String(),
                        Srednji_tecaj = c.String(),
                        Drzava = c.String(),
                        Sifra_Valute = c.String(),
                        Kupovni_tecaj = c.String(),
                        Prodajni_tecaj = c.String(),
                        Datum_primjene = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tecajs");
        }
    }
}
