using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.BLL.Entities
{
        [Table("Client")]
        public class Client
        {
            public int ClientId { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }

            public ICollection<Order> Orders { get; set; }
        }
}