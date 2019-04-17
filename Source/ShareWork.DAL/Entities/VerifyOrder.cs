using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL
    .Entities
{
    [Table("VerifyOrders")]
    public class VerifyOrder
    {
        [Key, ForeignKey("Order")]
        public int Id { get; set; }

            public virtual Client ServiceProvider { get; set; }

            public virtual Order Order { get; set; }
    }
}