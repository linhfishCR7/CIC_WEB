namespace CIC_WEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class them_Noi_Dung_va_HowCanWeHelp : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Services", "Noidung", c => c.String());
            AddColumn("dbo.Services", "HowCanWeHelp", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Services", "HowCanWeHelp");
            DropColumn("dbo.Services", "Noidung");
        }
    }
}
