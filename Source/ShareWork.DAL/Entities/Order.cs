using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL.Entities
{
    [Table("Order")]
    public class Order
    {
            public int OrderId { get; set; }
            public int CategoryId { get; set; }
            public string Header { get; set; }
            public string Discription { get; set; }
            public string City { get; set; }
            public DateTime? DateCreated { get; set; }
            public int CustomerId { get; set; }

            public Client Client { get; set; }
            public Categories Category { get; set; }
            public VerifyOrder VerifyOrders { get; set; }
    }
}