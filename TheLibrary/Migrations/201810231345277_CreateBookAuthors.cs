namespace FrontEnd.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class CreateBookAuthors : DbMigration
    {
        private const string SCHEMA = "dbo";
        private const string TABLE_BOOK_AUTHORS = "BookAuthors";
        private const string TABLE_BOOK = "Books";
        private const string TABLE_AUTHORS = "Authors";

        public override void Up()
        {
            CreateTable(
                $"{SCHEMA}.{TABLE_BOOK_AUTHORS}",
                 c => new
                 {
                     ID = c.Int(nullable: false, identity: true),
                     BookId = c.Int(nullable: false),
                     AuthorId = c.Int(nullable: false)
                 })
                 .PrimaryKey(t => t.ID)
                .ForeignKey($"{SCHEMA}.{TABLE_BOOK}", t => t.BookId)
                .ForeignKey($"{SCHEMA}.{TABLE_AUTHORS}", t => t.AuthorId);
        }
        
        public override void Down()
        {
            DropForeignKey($"{SCHEMA}.{TABLE_BOOK_AUTHORS}", "BookId");
            DropForeignKey($"{SCHEMA}.{TABLE_BOOK_AUTHORS}", "AuthorId");

            DropTable($"{SCHEMA}.{TABLE_BOOK_AUTHORS}");
        }
    }
}
