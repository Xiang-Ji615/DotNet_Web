namespace EddyProject_Dao.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class JJ1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.User",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(),
                        ReturnURL = c.String(),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.User");
        }
    }
}
