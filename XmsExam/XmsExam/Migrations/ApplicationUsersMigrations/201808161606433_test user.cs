namespace XmsExam.Migrations.ApplicationUsersMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class testuser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "TestUser", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "TestUser");
        }
    }
}
