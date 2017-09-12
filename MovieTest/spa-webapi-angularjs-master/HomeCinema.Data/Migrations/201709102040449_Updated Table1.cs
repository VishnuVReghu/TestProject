namespace HomeCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedTable1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Movie", "Genre_ID", "dbo.Genre");
            DropForeignKey("dbo.Stock", "MovieId", "dbo.Movie");
            DropIndex("dbo.Movie", new[] { "Genre_ID" });
            DropIndex("dbo.Stock", new[] { "MovieId" });
            RenameColumn(table: "dbo.Stock", name: "MovieId", newName: "Movie_ID");
            AddColumn("dbo.User", "Movie_ID", c => c.Int());
            AlterColumn("dbo.Stock", "Movie_ID", c => c.Int());
            CreateIndex("dbo.User", "Movie_ID");
            CreateIndex("dbo.Stock", "Movie_ID");
            AddForeignKey("dbo.User", "Movie_ID", "dbo.Movie", "ID");
            AddForeignKey("dbo.Stock", "Movie_ID", "dbo.Movie", "ID");
            DropColumn("dbo.Movie", "Genre_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movie", "Genre_ID", c => c.Int());
            DropForeignKey("dbo.Stock", "Movie_ID", "dbo.Movie");
            DropForeignKey("dbo.User", "Movie_ID", "dbo.Movie");
            DropIndex("dbo.Stock", new[] { "Movie_ID" });
            DropIndex("dbo.User", new[] { "Movie_ID" });
            AlterColumn("dbo.Stock", "Movie_ID", c => c.Int(nullable: false));
            DropColumn("dbo.User", "Movie_ID");
            RenameColumn(table: "dbo.Stock", name: "Movie_ID", newName: "MovieId");
            CreateIndex("dbo.Stock", "MovieId");
            CreateIndex("dbo.Movie", "Genre_ID");
            AddForeignKey("dbo.Stock", "MovieId", "dbo.Movie", "ID", cascadeDelete: true);
            AddForeignKey("dbo.Movie", "Genre_ID", "dbo.Genre", "ID");
        }
    }
}
