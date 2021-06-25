using IMS.BL;
using IMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.GUI_Forms
{
    public partial class SupplierOrders : Form
    {
     
        EmployeeBL emBL;
        AcceptOrder crDTO;
        public SupplierOrders()
        {
            InitializeComponent();
           
            emBL = new EmployeeBL();
            crDTO = new AcceptOrder(); 
        }

        private void btn_AcceptOrder_Click(object sender, EventArgs e)
        {
          
            if (dgv_SupplierOrders.CurrentRow != null)
            {
                crDTO.ItemName = dgv_SupplierOrders.CurrentRow.Cells[0].Value.ToString();
               

                if (MessageBox.Show("Do You Want to Accept the Order?", "Order Accepted" + crDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        emBL.AddAcceptedOrder(crDTO);
                        MessageBox.Show("Order Accepted Succesfullly");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Order Can't Accepted");

                    }
                    dgv_SupplierOrders.DataSource = emBL.ViewSupplirData();

                }
            }
            else
            {
                MessageBox.Show("Select at least one");
            }

        }

        private void SupplierOrders_Load(object sender, EventArgs e)
        {
            dgv_SupplierOrders.DataSource = emBL.ViewSupplirData();
        }

        private void btn_CancelOrder_Click(object sender, EventArgs e)
        {
            AddItemsDTO crDTO = new AddItemsDTO();
            if (dgv_SupplierOrders.CurrentRow != null)
            {
                crDTO.ItemName = dgv_SupplierOrders.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Are you really want to Cancel the Order?", "Cancel Order" + crDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        emBL.DelSupplierOrder(crDTO);
                        MessageBox.Show("Order Cancel Succesfullly");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Order Can't Cancel");

                    }
                    dgv_SupplierOrders.DataSource = emBL.ViewSupplirData();

                }
            }
            else
            {
                MessageBox.Show("Select at least one");
            }
    }
    }
}
