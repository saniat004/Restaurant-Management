using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace RestaurantManagementSystem
{
    public partial class AddNewItemDialog : Form
    {

        public BindingList<Food> foods = new BindingList<Food>();
        public static AddNewItemDialog newitemdialog = new AddNewItemDialog();
        
        public AddNewItemDialog()
        {
            InitializeComponent();
            //intiliaze foods 
            newitemdialog = this;
            

        }

        private void button1_Click(object sender, EventArgs e)

        {
          
           
           // foods.Add(new Food(nameTextBox.Text, categoryComboBox.Text, Convert.ToDouble(priceTextBox.Text), pictureBox1.Image));
            foods.Add(new Food(nameTextBox.Text, categoryComboBox.Text, Convert.ToDouble(priceTextBox.Text)));
            MessageBox.Show(nameTextBox.Text + " is  Added to the menu ");
            Menu menu = new Menu();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newitemdialog.Close();
        }

        private void AddNewItemDialog_Load(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(priceTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                priceTextBox.Text = priceTextBox.Text.Remove(priceTextBox.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        
            {
                /*selecting image*/

                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Title = "Select Image file..";
                ofd.DefaultExt = ".jpg";
                ofd.Filter = "Media Files|*.jpg;*.png;*.gif;*.bmp;*.jpeg|All Files|*.*";

                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                /*if picture selected then load in the picture box*/
                pictureBox1.Load(ofd.FileName);
                }
            }
        
    }
}
