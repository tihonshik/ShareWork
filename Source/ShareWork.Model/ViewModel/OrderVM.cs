using System;

namespace ShareWork.Model.ViewModel
{
    public class OrderVM
    {
        public int OrderId { get; set; }
        public int CategoryId { get; set; }
        public string Header { get; set; }
        public string Discription { get; set; }
        public string City { get; set; }
        public DateTime? DateCreated { get; set; }
        public int CustomerId { get; set; }
    }
}