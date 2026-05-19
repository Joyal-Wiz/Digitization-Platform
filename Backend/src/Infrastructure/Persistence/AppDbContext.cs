using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(
           DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }


        public DbSet<Customer> Customers { get; set; }

        public DbSet<UploadedDocument> UploadedDocuments { get; set; }


    }
}
