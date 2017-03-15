namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTipMejla : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO TipMejls (TipMejla) VALUES ('Posao')");
            Sql("INSERT INTO TipMejls (TipMejla) VALUES ('Privatni')");
        }
        
        public override void Down()
        {
        }
    }
}
