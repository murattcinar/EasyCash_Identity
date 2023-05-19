using EasyCashIdentityProject.EntityLayer.Concreate;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EasyCashIdentityProject.DataAccesLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MURAT;initial catalog=EasyCashDb;integrated Security=true");
        }
        public DbSet<CustomerAccount> CustomerAccounts  { get; set; }
        public DbSet<CustomerAccountProcess> CustomerAccountsProceses { get; set; }
    }
}
