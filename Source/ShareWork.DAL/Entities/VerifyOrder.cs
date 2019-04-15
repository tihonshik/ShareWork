using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL
    .Entities
{
    [Table("VerifyOrders")]
    public class VerifyOrder
    {
            public int OrderId { get; set; }

            public Client ServiceProviderId { get; set; }

            public Order Orders { get; set; }
    }
}