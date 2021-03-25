using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


    public class EMSContext : IdentityDbContext
    {
       
        public EMSContext(DbContextOptions<EMSContext> options) : base(options)
        {
        
        }

        public DbSet<Person> Employees{get;set;}
    }
