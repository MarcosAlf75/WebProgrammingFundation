namespace VideoRentalApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovieType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MovieTypes", "Movie_Id", c => c.Int());
            CreateIndex("dbo.MovieTypes", "Movie_Id");
            AddForeignKey("dbo.MovieTypes", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MovieTypes", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.MovieTypes", new[] { "Movie_Id" });
            DropColumn("dbo.MovieTypes", "Movie_Id");
        }
    }
}
