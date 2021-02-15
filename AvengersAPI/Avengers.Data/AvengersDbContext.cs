using Avengers.Data.Interface;
using Avengers.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Data
{
    public class AvengersDbContext  : DbContext, IAvengersDbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Subscription> Subscription { get; set; }

        public AvengersDbContext()
        {

        }
        public AvengersDbContext(DbContextOptions<AvengersDbContext> options) : base(options)
        {

        }
      
    }
}
