using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZaverecnyProjekt._6G.DAL
{
    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }

        public DateTime Created { get; set; }
        public DateTime Completed { get; set; }
        public DateTime Dispatched { get; set; }
        public DateTime Canceled { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}