using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZaverecnyProjekt._6G.DAL
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
        
        public int Count { get; set; }
        public int Price { get; set; }
    }
}