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
    public partial class AddKids : Form
    {
        kidsDTO kDTO;
        EmployeeBL emBL;
        public AddKids()
        {

            InitializeComponent();
            kDTO = new kidsDTO();
            emBL = new EmployeeBL();
        }

        private void AddKids_Load(object sender, EventArgs e)
        {

        }
        private void btn_Add_Food_Click(object sender, EventArgs e)
        {
            
        }
        private void txt_Kids_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Addkids_Click(object sender, EventArgs e)
        {
            if (!(txt_kids_ID.Text == ""))
            {
                string message = "Do you want to create account";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    kDTO.ItemId = txt_kids_ID.Text;
                    kDTO.Itemtype = txt_kids_type.Text;
                    kDTO.ItemName  = txt_kids_name.Text;
                    kDTO.Itemprice = txt_kids_price.Text;
                    kDTO.Itemremain = txt_kids_remaning.Text;
                    emBL.AddKids(kDTO);
                    MessageBox.Show("Item Added");
                    txt_kids_type.Text = " ";
                    txt_kids_name.Text = " ";
                    txt_kids_price.Text = " ";
                    txt_kids_remaning.Text = " ";
                    var Mform = new Employee();
                    Mform.Show();
                }

            }
        }
    }

    }
