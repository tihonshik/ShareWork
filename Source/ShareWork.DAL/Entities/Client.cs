using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL.Entities
{
        [Table("Client")]
        public class Client
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }

            public ICollection<Order> Orders { get; set; }
        }
}