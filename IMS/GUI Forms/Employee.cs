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
    public partial class Employee : Form
    {
        private EmployeeBL emBL;
        private UserDTO usDTO;
        
        public Employee()
        {
            InitializeComponent();
            emBL = new EmployeeBL();
            usDTO = new UserDTO();
            
        }

        private void Employee_Load(object sender, EventArgs e)
        {

            dgv_Food_Emp.DataSource = emBL.ViewFood();
            dgv_Beauty_Emp.DataSource = emBL.ViewBeauty();
            dgv_Gaming_Emp.DataSource = emBL.ViewGaming();
            dgv_Kids_Emp.DataSource = emBL.ViewKids();



        }

        private void btn_Del_Food_Click(object sender, EventArgs e)
        {
            AddItemsDTO crDTO = new AddItemsDTO();
            if (dgv_Food_Emp.CurrentRow != null)
            {
                crDTO.ItemName = dgv_Food_Emp.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Are you really want to Delete this Item?", "Deleting Item" + crDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        emBL.Del_Items(crDTO);
                        MessageBox.Show("Item Deleted Succesfullly");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Item has not been Deleted");

                    }
                    dgv_Food_Emp.DataSource = emBL.ViewFood();

                }
            }
            else
            {
                MessageBox.Show("Select at least one");
            }
        }


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            var myForm = new AddFood();
            myForm.Show();
            
        }

        private void btn_badd_Click(object sender, EventArgs e)
        {
            var myForm = new Addbeauty();
            myForm.Show();
        }

        private void btn_kadd_Click(object sender, EventArgs e)
        {
            var myForm = new AddKids();
            myForm.Show();
        }

        private void btn_cAdd_Click(object sender, EventArgs e)
        {
            var myForm = new Addgame();
            myForm.Show();

        }

        private void btn_Del_Beauty_Click(object sender, EventArgs e)
        {
            AddItemsDTO crBDTO = new AddItemsDTO();
            if (dgv_Beauty_Emp.CurrentRow != null)
            {
                crBDTO.ItemName = dgv_Beauty_Emp.CurrentRow.Cells[0].Value.ToString();

                if (MessageBox.Show("Are you really want to Delete this Item?", "Deleting Item" + crBDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        emBL.Del_Beauty(crBDTO);
                        MessageBox.Show("Item Deleted Succesfullly");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Item has not been Deleted");

                    }
                    dgv_Beauty_Emp.DataSource = emBL.ViewBeauty();


                }
            }
            else
            {
                MessageBox.Show("Select at least one");
            }

        }

        private void btn_Del_K_Click(object sender, EventArgs e)
        {
            AddItemsDTO crDTO = new AddItemsDTO();
            if (dgv_Kids_Emp.CurrentRow != null)
            { 
                crDTO.ItemName = dgv_Kids_Emp.CurrentRow.Cells[0].Value.ToString();


            if (MessageBox.Show("Are you really want to Delete this Item?", "Deleting Item" + crDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    emBL.Del_kids(crDTO);
                    MessageBox.Show("Item Deleted Succesfullly");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Item has not been Deleted");

                }
                dgv_Kids_Emp.DataSource = emBL.ViewKids();

            }
           }
            else
            {
                MessageBox.Show("Select At least one");
            }
        }

        private void btn_Del_Comp_Click(object sender, EventArgs e)
        {
            AddItemsDTO crDTO = new AddItemsDTO();
            if (dgv_Gaming_Emp.CurrentRow != null)
            {
                crDTO.ItemName = dgv_Gaming_Emp.CurrentRow.Cells[0].Value.ToString();


                if (MessageBox.Show("Are you really want to Delete this Item?", "Deleting Item" + crDTO.ItemName, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        emBL.Del_games(crDTO);
                        MessageBox.Show("Item Deleted Succesfullly");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Item has not been Deleted");

                    }
                    dgv_Gaming_Emp.DataSource = emBL.ViewGaming();

                }
            }
            else
            {
                MessageBox.Show("At least select one");
            }

        }

        private void dgv_Beauty_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            var myForm = new OrderSupplir();
            myForm.Show();
        }

        private void btn_ViewOrder_Click(object sender, EventArgs e)
        {
            var myForm = new ViewOrderSupplir();
            myForm.Show();
        }

        private void dgv_Food_Emp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_OrderItem_Click(object sender, EventArgs e)
        {
            var myForm = new OrderSupplir();
            myForm.Show();
        }

        private void btn_order_Item_Click(object sender, EventArgs e)
        {
            var myForm = new OrderSupplir();
            myForm.Show();

        }

        private void btn_Order_Com_Click(object sender, EventArgs e)
        {
            var myForm = new OrderSupplir();
            myForm.Show();
        }

        private void btn_OrderView_Click(object sender, EventArgs e)
        {
            var myForm = new ViewOrderSupplir();
            myForm.Show();

        }

        private void btn_ViewOrd_Click(object sender, EventArgs e)
        {
            var myForm = new ViewOrderSupplir();
            myForm.Show();
        }

        private void btn_View_Click(object sender, EventArgs e)
        {
            var myForm = new ViewOrderSupplir();
            myForm.Show();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
