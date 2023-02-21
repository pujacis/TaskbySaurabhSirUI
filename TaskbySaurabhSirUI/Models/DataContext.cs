using Microsoft.EntityFrameworkCore;
using System.Net;
using TaskbySaurabhSirUI.Models;

namespace TaskbySaurabhSirUI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }
      
        public DbSet<RepoWithCountry> country { get; set; }
        public DbSet<RepoWithCity> City { get; set; }
        public DbSet<RepoWithState> State { get; set; }
       
        //public  DbSet<RepoWithCity> RepoWithCities { get; set; }
        //public  DbSet<RepoWithCountry> RepoWithCountries { get; set; }
        //public  DbSet<RepoWithState> RepoWithStates { get; set; }
    }
}
