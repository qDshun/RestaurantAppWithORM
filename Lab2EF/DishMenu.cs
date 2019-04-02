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
    public partial class DishMenu : Form
    {
        public DishMenu()
        {
            InitializeComponent();
        }

        private void DishMenu_Load(object sender, EventArgs e)
        {
            RestController.RefreshDishMenu(dataGridView1, dishMenuBindingSource);
            RestController.FillCategoriesComboBox(comboBoxDishCategory);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //try
            {
                int category_id = Convert.ToInt32(comboBoxDishCategory.SelectedItem.ToString().Split(' ')[0]);
                int price = Convert.ToInt32(textBoxPrice.Text);
                int amount = Convert.ToInt32(textBoxAmount.Text);
                string name = textBoxName.Text;
                RestController.AddDish(category_id, price, amount, name, dataGridView1);
                RestController.RefreshDishMenu(dataGridView1, dishMenuBindingSource);
            }
            //catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RestController.DeleteSelectedDish(dataGridView1);
            RestController.RefreshDishMenu(dataGridView1, dishMenuBindingSource);
        }
    }
}
