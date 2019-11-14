namespace CodeFirstTPT.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class yopla : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animaux",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Male = c.Boolean(nullable: false),
                        Femelle = c.Boolean(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 50),
                        Espece = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Mammifere",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        AquatiqueStrict = c.Boolean(nullable: false),
                        ADesDents = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Animaux", t => t.ID)
                .Index(t => t.ID);
            
            CreateTable(
                "dbo.Oiseau",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        SaitVoler = c.Boolean(nullable: false),
                        DateDeNaissance = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Animaux", t => t.ID)
                .Index(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Oiseau", "ID", "dbo.Animaux");
            DropForeignKey("dbo.Mammifere", "ID", "dbo.Animaux");
            DropIndex("dbo.Oiseau", new[] { "ID" });
            DropIndex("dbo.Mammifere", new[] { "ID" });
            DropTable("dbo.Oiseau");
            DropTable("dbo.Mammifere");
            DropTable("dbo.Animaux");
        }
    }
}
