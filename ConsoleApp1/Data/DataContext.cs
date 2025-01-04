using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp1.Data;

internal class DataContext : DbContext
{


    public DbSet<Aircraft> aircraft { get; set; }
    public DbSet<Airline> airline { get; set; }
    public DbSet<City> city { get; set; }

    public DbSet<Flights> flights{ get; set; }
    public DbSet<Passenger> passenger { get; set; }

    public DbSet<Boarding> boarding { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Air_tickets;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

    }






}
