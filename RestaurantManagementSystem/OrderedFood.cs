using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class OrderedFood : Food
    {
        public int Quantity { get; set; }
        
        public OrderedFood(string name, string cat, double price, int quantity) : base(name, cat, price)
        {
            Quantity = quantity;
        }
    }
}
