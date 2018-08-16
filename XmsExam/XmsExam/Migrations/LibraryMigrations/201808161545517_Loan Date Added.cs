namespace XmsExam.Migrations.LibraryMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LoanDateAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Loans", "DateJoined", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Loans", "DateJoined");
        }
    }
}
