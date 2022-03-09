using ASPChushka1.Data;
using Chushka1.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ASPChushka.Data
{
    public class Chushka1Context : IdentityDbContext<Users>
    {
        // Constructors
      
        public Chushka1Context(DbContextOptions<Chushka1Context> options) :
            base(options)
        {

        }

        // Tables
        
        public DbSet<Products> Products { get; set; }
        public  DbSet<Orders> Orders { get; set; }


    }
}  
