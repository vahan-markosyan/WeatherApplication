using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WeatherApplication.Data.Entities;


namespace WeatherApplication.Data.DAO;

public class ApplicationDbContext : DbContext
{
    // This is a public constructor
    // This constructor takes in a parameter of type DbContextOptions
    // This constructor calls the base constructor and passes in the options parameter
    // DbContextOptions is a class that is used to configure the DbContext class
    // DbContextOptions is a class that is used to configure the connection string
    // DbContextOptions is a class that is used to configure the database provider
    // DbContextOptions is a class that is used to configure the database provider options
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {  
    }
    

    // This is a public property
    // This property is of type DbSet
    // DbSet is a class that is used to query a database
    // DbSet is a class that is used to save data to a database
    public DbSet<Clouds> Clouds { get; set; } //dbset y table a libraries anunov
    public DbSet<Coord> Coord { get; set; }
    public DbSet<Main> Main { get; set; }
    public DbSet<Root> Root { get; set; }
    public DbSet<Weather> Weather { get; set; }
    public DbSet<Wind> Wind { get; set; }
    
}