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
    public partial class AddFood : Form
    {
        private readonly object dgv_Food_Emp;
        FoodDTO fDTO;
        EmployeeBL emBL;
        public AddFood()
        {
            InitializeComponent();
            fDTO = new FoodDTO();
            emBL = new EmployeeBL();
        }

        private void AddFood_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Food_Click(object sender, EventArgs e)
        {
            if (!(txt_Food_ID.Text == ""))
            {
                string message = "Do you want to Add Item";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    fDTO.ItemId = txt_Food_ID.Text;
                    fDTO.ItemName = txt_Food_Name.Text;
                    fDTO.Itemcompany = txt_Food_Comp.Text;
                    fDTO.Itemtype = txt_Food_Type.Text;
                    fDTO.Itemprice = txt_Food_Price.Text;
                    fDTO.Itemweight = txt_Food_Weight.Text;
                    fDTO.MfgDate = txt_Food_mfgDate.Text;
                    fDTO.ExpDate = txt_Food_ExpDate.Text;
                    fDTO.Itemremain = txt_Food_Rem.Text;
                    emBL.AddFood(fDTO);
                    MessageBox.Show("Item Added");
                    txt_Food_ID.Text = " ";
                    txt_Food_Name.Text = " ";
                    txt_Food_Comp.Text = " ";
                    txt_Food_Type.Text = " ";
                    txt_Food_Price.Text = " ";
                    txt_Food_Weight.Text = " ";
                    txt_Food_mfgDate.Text = " ";
                    txt_Food_ExpDate.Text = " ";
                    txt_Food_Rem.Text = " ";
                    var Mform = new Employee();
                    Mform.Show();
                }

            }
        }

        private void txt_Food_ID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
