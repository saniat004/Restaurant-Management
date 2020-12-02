using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{


    public class Food
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
       // public byte[] ProductPicture;


        public Food(string name, string cat, double price)
        {
            Name = name;
            Category = cat;
            Price = price;
           // ProductPicture = GivenProductPicture;
        }

    }
}
