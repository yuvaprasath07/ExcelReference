using Entity.Model;
using Microsoft.EntityFrameworkCore;

namespace Entity
{
    public class CustomerDbcontext : DbContext
    {
        public CustomerDbcontext(DbContextOptions<CustomerDbcontext> options) : base(options)
        {

        }
        public DbSet<L_CustomerType> L_CustomerType { get; set; }

        public DbSet<L_PaymentCategory> L_PaymentCategory { get; set; }

        public DbSet<UtilityModel> L_Utility { get; set; }
    }
}
