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
    public partial class Menu : Form
    {
        public static Menu menu = new Menu();
        public Menu()
        {
            InitializeComponent();
            menu = this;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            listBox1.DataSource = AddNewItemDialog.newitemdialog.foods;
            listBox1.DisplayMember = "Name";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = (listBox1.SelectedItem as Food).Name;
            label2.Text = (listBox1.SelectedItem as Food).Category;
            label3.Text = (listBox1.SelectedItem as Food).Price.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Close();
        }
    }
}
