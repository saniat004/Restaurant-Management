using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantManagementSystem
{
    public class Datetime1
    {
        

        public Datetime1(string text, int v)
        {
            Time = text;
            Guests = v;
        }

        public string Time { get; set; }
        public int Guests { get; set; }

    } 
}