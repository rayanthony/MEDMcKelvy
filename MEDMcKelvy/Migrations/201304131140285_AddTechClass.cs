namespace MEDMcKelvy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTechClass : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Technologies",
                c => new
                    {
                        T_ID = c.Int(nullable: false, identity: true),
                        T_Name = c.String(nullable: false),
                        T_Desc = c.String(),
                        T_QOH = c.Int(nullable: false),
                        T_URL = c.String(),
                    })
                .PrimaryKey(t => t.T_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Technologies");
        }
    }
}
