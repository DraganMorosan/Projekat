namespace Projekat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnosObrazac : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Grads",
                c => new
                    {
                        GradID = c.Int(nullable: false, identity: true),
                        NazivGrada = c.String(),
                        OpstinaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GradID);
            
            CreateTable(
                "dbo.KontaktTelefons",
                c => new
                    {
                        KontaktTelefonID = c.Int(nullable: false, identity: true),
                        BrojTelefona = c.Int(nullable: false),
                        Lokal = c.String(),
                        SifraTipaKontaktTelefon = c.Int(nullable: false),
                        OsobaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KontaktTelefonID);
            
            CreateTable(
                "dbo.Mejls",
                c => new
                    {
                        MejlID = c.Int(nullable: false, identity: true),
                        NazivMejla = c.String(),
                        TipMejlaID = c.Int(nullable: false),
                        OsobaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MejlID);
            
            CreateTable(
                "dbo.Mestoes",
                c => new
                    {
                        MestoID = c.Int(nullable: false, identity: true),
                        NazivMesta = c.String(),
                        OpstinaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MestoID);
            
            CreateTable(
                "dbo.Opstinas",
                c => new
                    {
                        OpstinaID = c.Int(nullable: false, identity: true),
                        NazivOpstine = c.String(),
                    })
                .PrimaryKey(t => t.OpstinaID);
            
            CreateTable(
                "dbo.Osobas",
                c => new
                    {
                        OsobaID = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        ImeRoditelja = c.String(),
                        JMBG = c.Int(nullable: false),
                        DatumRodjenja = c.DateTime(nullable: false),
                        BrojLicneKarte = c.Int(nullable: false),
                        AdresaID = c.Int(nullable: false),
                        MejlID = c.Int(nullable: false),
                        KontaktTelefonID = c.Int(nullable: false),
                        OpstinaID = c.Int(nullable: false),
                        PolID = c.Int(nullable: false),
                        MestoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OsobaID)
                .ForeignKey("dbo.KontaktTelefons", t => t.KontaktTelefonID, cascadeDelete: true)
                .ForeignKey("dbo.Mejls", t => t.MejlID, cascadeDelete: true)
                .ForeignKey("dbo.Mestoes", t => t.MestoID, cascadeDelete: true)
                .ForeignKey("dbo.Opstinas", t => t.OpstinaID, cascadeDelete: true)
                .ForeignKey("dbo.PolOsobes", t => t.PolID, cascadeDelete: true)
                .ForeignKey("dbo.PttAdresas", t => t.AdresaID, cascadeDelete: true)
                .Index(t => t.AdresaID)
                .Index(t => t.MejlID)
                .Index(t => t.KontaktTelefonID)
                .Index(t => t.OpstinaID)
                .Index(t => t.PolID)
                .Index(t => t.MestoID);
            
            CreateTable(
                "dbo.PolOsobes",
                c => new
                    {
                        PolID = c.Int(nullable: false, identity: true),
                        Pol = c.String(),
                    })
                .PrimaryKey(t => t.PolID);
            
            CreateTable(
                "dbo.PttAdresas",
                c => new
                    {
                        AdresaID = c.Int(nullable: false, identity: true),
                        NazivPttAdresa = c.String(),
                        PostanskiBroj = c.Int(nullable: false),
                        TipAdreseID = c.Int(nullable: false),
                        GradID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AdresaID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Stanovanjes",
                c => new
                    {
                        OsobaID = c.Int(nullable: false),
                        AdresaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OsobaID, t.AdresaID });
            
            CreateTable(
                "dbo.TipKontaktTelefons",
                c => new
                    {
                        TipKontaktTelefonID = c.Int(nullable: false, identity: true),
                        TipKontaktTelefona = c.String(),
                    })
                .PrimaryKey(t => t.TipKontaktTelefonID);
            
            CreateTable(
                "dbo.TipMejls",
                c => new
                    {
                        TipMejlaID = c.Int(nullable: false, identity: true),
                        TipMejla = c.String(),
                    })
                .PrimaryKey(t => t.TipMejlaID);
            
            CreateTable(
                "dbo.TipPttAdrese",
                c => new
                    {
                        TipaAdreseID = c.Int(nullable: false, identity: true),
                        TipAdrese = c.String(),
                    })
                .PrimaryKey(t => t.TipaAdreseID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Osobas", "AdresaID", "dbo.PttAdresas");
            DropForeignKey("dbo.Osobas", "PolID", "dbo.PolOsobes");
            DropForeignKey("dbo.Osobas", "OpstinaID", "dbo.Opstinas");
            DropForeignKey("dbo.Osobas", "MestoID", "dbo.Mestoes");
            DropForeignKey("dbo.Osobas", "MejlID", "dbo.Mejls");
            DropForeignKey("dbo.Osobas", "KontaktTelefonID", "dbo.KontaktTelefons");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Osobas", new[] { "MestoID" });
            DropIndex("dbo.Osobas", new[] { "PolID" });
            DropIndex("dbo.Osobas", new[] { "OpstinaID" });
            DropIndex("dbo.Osobas", new[] { "KontaktTelefonID" });
            DropIndex("dbo.Osobas", new[] { "MejlID" });
            DropIndex("dbo.Osobas", new[] { "AdresaID" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TipPttAdrese");
            DropTable("dbo.TipMejls");
            DropTable("dbo.TipKontaktTelefons");
            DropTable("dbo.Stanovanjes");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.PttAdresas");
            DropTable("dbo.PolOsobes");
            DropTable("dbo.Osobas");
            DropTable("dbo.Opstinas");
            DropTable("dbo.Mestoes");
            DropTable("dbo.Mejls");
            DropTable("dbo.KontaktTelefons");
            DropTable("dbo.Grads");
        }
    }
}
