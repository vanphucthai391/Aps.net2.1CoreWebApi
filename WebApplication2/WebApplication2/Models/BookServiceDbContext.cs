﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class BookServiceDbContext:DbContext
    {

        public BookServiceDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }   
}
