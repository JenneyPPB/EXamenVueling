namespace Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDataBase2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Fecha", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Fecha");
        }
    }
}
