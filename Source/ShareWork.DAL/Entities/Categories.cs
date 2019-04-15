using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShareWork.DAL.Entities
{ 
        [Table("Category")]
        public class Categories
        {
            public int CategoryId { get; set; }

            public string CategoryName { get; set; }

            public ICollection<Order> Orderses { get; set; }
            public Categories()
            {
                Orderses = new List<Order>();
            }
        }
}