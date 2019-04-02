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
    public partial class OrderDetails : Form
    {
        int OrderId = -1;
        public OrderDetails(int order_id)
        {
            InitializeComponent();
            OrderId = order_id;
            if (OrderId >= 0)
                labelInfo.Text = "Details for order № " + OrderId;
            RestController.RefreshOrderDetails(dataGridViewComments, OrderId);
        }
    }
}
