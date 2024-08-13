using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstAPI.Models;
using Microsoft.EntityFrameworkCore;


namespace FirstAPI.DataAccess
{
    public class TodoDbContex : DbContext
    {
        public DbSet<Todo> Todos { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost; Database=MyTodoDb; Trusted_Connection=True; TrustServerCertificate=True;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "Dineth Janitha"},
                new Author { Id = 2, FullName = "Sahan Madawa"},
                new Author { Id = 3, FullName = "Pasan Yasas"},
                new Author { Id = 4, FullName = "Chamod Lakshitha"},
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[] {
               new Todo
               {
                    Id = 1,
                    Title = "Test 1",
                    Description = "Test Description 1 - DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.New,
                    AuthorId = 1,
               },
               new Todo
               {
                    Id = 2,
                    Title = "Test 2",
                    Description = "Test Description 3 - DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.Inprogress,
                    AuthorId = 3,
               },
               new Todo
               {
                    Id = 3,
                    Title = "Test 3",
                    Description = "Test Description 3 - DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.Completed,
                    AuthorId = 2,
               },
               new Todo
               {
                    Id = 4,
                    Title = "Test 4",
                    Description = "Test Description 4 - DB",
                    Created = DateTime.Now,
                    Due = DateTime.Now.AddDays(1),
                    Status = TodoStatus.New,
                    AuthorId = 4,
               },
            });
        }
    }
}

//din98#4DK19%
//work correctly
//test push