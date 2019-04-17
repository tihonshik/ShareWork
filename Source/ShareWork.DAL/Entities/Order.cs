using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL.Entities
{
    [Table("Order")]
    public class Order
    {
            public int Id { get; set; }
            public int CategoryId { get; set; }
            public string Header { get; set; }
            public string Discription { get; set; }
            public string City { get; set; }
            public DateTime? DateCreated { get; set; }
            public int CustomerId { get; set; }

            public virtual Client Client { get; set; }
            public virtual Categories Categories { get; set; }
            public virtual VerifyOrder VerifyOrder { get; set; }
    }
}