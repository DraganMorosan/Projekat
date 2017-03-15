namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePolOsobe : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PolOsobes (Pol) VALUES ('Muski')");
            Sql("INSERT INTO PolOsobes (Pol) VALUES ('Zenski')");
        }
        
        public override void Down()
        {
        }
    }
}
