using Avengers.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avengers.Data.Interface
{
    public interface IAvengersDbContext : IDisposable, IDbContext
    {
        DbSet<Customer> Customer { get; set; }
        DbSet<Subscription> Subscription { get; set; }
    }
}
