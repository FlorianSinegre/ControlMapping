namespace ChatonCodeFirst.ORM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hop : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Proprietaires",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(maxLength: 50),
                        Prenom = c.String(maxLength: 50),
                        DateDeNaissance = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProprietaireChatons",
                c => new
                    {
                        Proprietaire_Id = c.Int(nullable: false),
                        Chaton_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Proprietaire_Id, t.Chaton_Id })
                .ForeignKey("dbo.Proprietaires", t => t.Proprietaire_Id, cascadeDelete: true)
                .ForeignKey("dbo.Chatons", t => t.Chaton_Id, cascadeDelete: true)
                .Index(t => t.Proprietaire_Id)
                .Index(t => t.Chaton_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProprietaireChatons", "Chaton_Id", "dbo.Chatons");
            DropForeignKey("dbo.ProprietaireChatons", "Proprietaire_Id", "dbo.Proprietaires");
            DropIndex("dbo.ProprietaireChatons", new[] { "Chaton_Id" });
            DropIndex("dbo.ProprietaireChatons", new[] { "Proprietaire_Id" });
            DropTable("dbo.ProprietaireChatons");
            DropTable("dbo.Proprietaires");
        }
    }
}
