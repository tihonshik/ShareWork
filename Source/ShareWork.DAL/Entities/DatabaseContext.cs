using System.Data.Entity;

namespace ShareWork.BLL.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Categories> Categorieses { get; set; }
        public virtual DbSet<VerifyOrder> VerifyOrders { get; set; }

    }

}