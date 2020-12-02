using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class OrderTime : Form
    {

    
        public static OrderTime o = new OrderTime();
        public string Time
        {
            get {return dateTimePicker1.Text; }
            
        }
        public string Numberofguests
        {
            get { return GuestsNumber.Text; }

        }
        public OrderTime()
        {
            InitializeComponent();
            
        }

   

        private void OrderTime_Load(object sender, EventArgs e)
        {

        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void Done_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Table has been reserved successfully ");
            o.Close();   
           
        }

        private void GuestsNumber_TextChanged(object sender, EventArgs e)
        {
            
                 if (System.Text.RegularExpressions.Regex.IsMatch(GuestsNumber.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                GuestsNumber.Text = GuestsNumber.Text.Remove(GuestsNumber.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

       
    }
