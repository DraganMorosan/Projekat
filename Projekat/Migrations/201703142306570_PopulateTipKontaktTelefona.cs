namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTipKontaktTelefona : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipKontaktTelefons (TipKontaktTelefona) VALUES ('Mobilni')");
            Sql("INSERT INTO TipKontaktTelefons (TipKontaktTelefona) VALUES ('Sluzbeni mobilni')");
            Sql("INSERT INTO TipKontaktTelefons (TipKontaktTelefona) VALUES ('Kuca')");
            Sql("INSERT INTO TipKontaktTelefons (TipKontaktTelefona) VALUES ('Posao')");
        }
        
        public override void Down()
        {
        }
    }
}
