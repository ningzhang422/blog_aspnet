namespace BlogSansLogin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class corps_required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articles", "Corps", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Articles", "Corps", c => c.String());
        }
    }
}
