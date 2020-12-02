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
    public partial class Order : Form
    {

        public TableInfo info = new TableInfo( );
        //OrderTime o = new OrderTime();




        /* public string time
         {
             get { return timelabel.Text; }
             set { timelabel.Text = value; }
         }
         */

        public Order(string n)
        {
            
            InitializeComponent();

            info.TableName = n;
        }

        private void Order_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = AddNewItemDialog.newitemdialog.foods;
            comboBox1.DisplayMember = "Name";
            listBox1.DataSource = info.orders;
            listBox1.DisplayMember = "Name";
            label5.Text = "Order for " + info.TableName;

           

            

            // Guestlabel.Text =Convert.ToInt32( info.NumberofGuests);
        }
        //    

        private void button1_Click(object sender, EventArgs e)
        {
            
            info.GetOrder(comboBox1.SelectedItem as Food, Convert.ToInt32(textBox1.Text));
            MessageBox.Show( "Item is Added to the Order ");

            listBox1.Refresh();
            

        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string name = ((OrderedFood)e.ListItem).Name.ToString();
            string quantity = ((OrderedFood)e.ListItem).Quantity.ToString();
            string Totalprice = (((OrderedFood)e.ListItem).Price * ((OrderedFood)e.ListItem).Quantity).ToString();
            
            e.Value = quantity + "x " + name + "\t" +                  Totalprice + " zl"  ;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrderTime o = new OrderTime();
            
            o.Show();
            o.Visible = false;
            if (o.ShowDialog() == DialogResult.OK)

            {
                timelabel.Text = o.Time;
                Guestlabel.Text = o.Numberofguests;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
                
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
