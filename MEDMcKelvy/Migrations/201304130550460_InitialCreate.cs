namespace MEDMcKelvy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supplies",
                c => new
                    {
                        S_ID = c.Int(nullable: false, identity: true),
                        S_Name = c.String(nullable: false),
                        S_Desc = c.String(),
                        S_QOH = c.Int(nullable: false),
                        S_URL = c.String(),
                    })
                .PrimaryKey(t => t.S_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Supplies");
        }
    }
}
