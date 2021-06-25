using IMS.BL;
using IMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.GUI_Forms
{
    public partial class OrderSupplir : Form
    {
        SupplirDTO supplirDTO;
        EmployeeBL emBL;
        public OrderSupplir()
        {
            InitializeComponent();
            supplirDTO = new SupplirDTO();
            emBL = new EmployeeBL();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {

            if (text_Name.Text != "" && text_Company.Text !="" && text_Quantity.Text!="")
            {
                string message = "Do you want to create account";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    supplirDTO.ItemName = text_Name.Text;
                    supplirDTO.CompanyName = text_Company.Text;
                    supplirDTO.Quantity = int.Parse(text_Quantity.Text);

                    emBL.OrderToSupplir(supplirDTO);
                    MessageBox.Show("Item Added");

                    text_Name.Text = " ";
                    text_Company.Text = " ";
                    text_Quantity.Text = " ";

                    var Mform = new Employee();

                    Mform.Show();
                }
            }
            else
            {
                MessageBox.Show("Select at least one");
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderSupplir_Load(object sender, EventArgs e)
        {

        }
    }
}
