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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            
            RestController.RefreshStaff(dataGridView1);
            RestController.FillPositionComboBox(comboBoxPosition);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RestController.AddWorker(textBoxName.Text, textBoxPassportID.Text, textBoxEmail.Text,
                Convert.ToInt32(comboBoxPosition.SelectedItem.ToString().Split(' ')[0]));
            RestController.RefreshStaff(dataGridView1);
            RestController.FillPositionComboBox(comboBoxPosition);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            RestController.DeleteSelectedWorker(dataGridView1);
            RestController.RefreshStaff(dataGridView1);
            RestController.FillPositionComboBox(comboBoxPosition);
        }
    }
}
