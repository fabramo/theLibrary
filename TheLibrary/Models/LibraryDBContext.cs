﻿using System.Data.Entity;

namespace FrontEnd.Models
{
    public class LibraryDBContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthors> BookAuthors { get; set; }
        public DbSet<User> Users { get; set; }
    }
}