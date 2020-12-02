using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    public class TableInfo
    {
        public string TableName { get; set; }
      
        public BindingList<OrderedFood> orders = new BindingList<OrderedFood>();
      

        public void GetOrder(Food order, int quantity)
        {
            OrderedFood o = new OrderedFood(order.Name, order.Category, order.Price, quantity);

            if (orders.Contains(o))
                orders[orders.IndexOf(o)].Quantity += quantity;
            else
                orders.Add(o);
           


            /*
             OrderedFood o = new OrderedFood(order.Name, order.Category, order.Price, quantity);
                foreach (var ord in orders)
                    if (ord.Name == o.Name)
                    {
                        ord.Quantity += quantity;
                        return;
                    }
                orders.Add(o);
                */
        }

    }
}
