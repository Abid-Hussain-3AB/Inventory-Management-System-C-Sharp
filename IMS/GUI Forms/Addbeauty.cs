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
    public partial class Addbeauty : Form
    {
        private readonly object dgv_beauty_Emp;
        beautyDTO bDTO;
        EmployeeBL emBL;
        public Addbeauty()
        {
            InitializeComponent();
            bDTO = new beautyDTO();
            emBL = new EmployeeBL();
        }

        private void Addbeauty_Load(object sender, EventArgs e)
        {

        }
        private void btn_Addbeauty_Click_1(object sender, EventArgs e)
        {
            if (!(txt_ID.Text == ""))
            {
                string message = "Do you want to create account";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    bDTO.Itemid = txt_ID.Text;
                    bDTO.ItemName = txt_beauty_name.Text;
                    bDTO.Itemcompany = txt_beauty_company.Text;
                    bDTO.Itemtype = txt_beauty_type.Text;
                    bDTO.Itemprice = txt_beauty_price.Text;
                    bDTO.Itemremain = txt_beauty_ream.Text;
                    emBL.Addbeauty(bDTO);
                    MessageBox.Show("Item Added");

                    txt_beauty_name.Text = " ";
                    txt_beauty_company.Text = " ";
                    txt_beauty_type.Text = " ";
                    txt_beauty_price.Text = " ";



                    txt_beauty_ream.Text = " ";
                    var Mform = new Employee();

                    Mform.Show();
                }
            }
        }
    }
}
