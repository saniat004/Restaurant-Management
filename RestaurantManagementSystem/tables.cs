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
    public partial class tables : Form
    {
        public tables()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            //OrderTime p = new OrderTime();
            //p.Show();
            o.Show();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            BookedTable1 b = new BookedTable1();
            b.Show();
            this.Close();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            o.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            o.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AddNewItemDialog f = new AddNewItemDialog();
            f.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
            m.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bookedtable2 b = new Bookedtable2();
            b.Show();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            //OrderTime p = new OrderTime();
            //p.Show();
            o.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Order o = new Order((sender as Button).Text);
            //OrderTime p = new OrderTime();
            //p.Show();
            o.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Bookedtable3 b = new Bookedtable3();
            b.Show();
            this.Close();
        }

        private void tables_Load(object sender, EventArgs e)
        {

        }
    }
}
