using System.Data.Entity;
using ShareWork.DAL.Entities;

namespace ShareWork.DAL.Entities
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

        public static DatabaseContext Create()
        {
            return new DatabaseContext();
        }
    }


    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext db)
        {
            db.Categorieses.Add(new Categories {Id = 1, CategoryName = "Photo"});
            db.SaveChanges();
        }
    }

}