using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2EF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RestController.FillOrderDetailsComboBox(comboBoxOrderDetails);
            RestController.FillOrderDetailsComboBox(comboBoxOrder);
            RestController.FillDishesComboBox(comboBoxDish);
            RestController.RefreshOrderDishes(dataGridView1);

        }

        private void dishesWCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DishMenu dishMenu = new DishMenu();
            dishMenu.Show();
        }

        private void staffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetails orderDetails = new OrderDetails(Convert.ToInt32(comboBoxOrderDetails.SelectedItem));
                orderDetails.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int dish_id = Convert.ToInt32(comboBoxDish.SelectedItem.ToString().Split(' ')[0]);
            int dishes_count = Convert.ToInt32(textBoxCount.Text);
            int order_id = Convert.ToInt32(comboBoxOrder.SelectedItem);
            RestController.AddDishToOrder(dish_id, dishes_count, order_id);
            RestController.RefreshOrderDishes(dataGridView1);
            RestController.FillOrderDetailsComboBox(comboBoxOrderDetails);
            RestController.FillOrderDetailsComboBox(comboBoxOrder);
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            RestController.AddOrder(dateTimePickerOrder.Value, Convert.ToInt32(textBoxTableID.Text));
            RestController.RefreshOrderDishes(dataGridView1);
            RestController.FillOrderDetailsComboBox(comboBoxOrderDetails);
            RestController.FillOrderDetailsComboBox(comboBoxOrder);
        }
    }
}
