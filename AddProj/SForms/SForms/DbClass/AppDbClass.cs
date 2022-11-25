
using Microsoft.EntityFrameworkCore;
using SForms.Models;

namespace SForms.DbClass

{
    public class AppDbClass : DbContext
    {
        public AppDbClass(DbContextOptions<AppDbClass> op):base(op)
        {

        }
        public DbSet<City> cities { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<Standard> standards { get; set; }
        public DbSet<Registration> registrations { get; set; }
        public DbSet<RegistrationDetails> registrationList { get; set; }

    }
}
