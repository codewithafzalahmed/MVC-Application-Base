namespace MVCBaseApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class userbirthday : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "BirthDay", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BirthDay");
        }
    }
}
