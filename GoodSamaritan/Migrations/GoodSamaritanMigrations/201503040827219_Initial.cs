namespace GoodSamaritan.Migrations.GoodSamaritanMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.SmartModels", name: "SexWorkerExploitation_SexWorkExploitation", newName: "SexWorkerExploitation_SexWorkerExploitation");
            RenameIndex(table: "dbo.SmartModels", name: "IX_SexWorkerExploitation_SexWorkExploitation", newName: "IX_SexWorkerExploitation_SexWorkerExploitation");
            CreateTable(
                "dbo.SexWorkerExploitationModels",
                c => new
                    {
                        SexWorkerExploitation = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SexWorkerExploitation);
        }
        
        public override void Down()
        {
        }
    }
}
