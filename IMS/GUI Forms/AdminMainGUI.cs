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
    public partial class AdminMainGUI : Form
    {
        private AdminBL adBL;
        private UserDTO usDTO;

        public AdminMainGUI()
        {
            InitializeComponent();
            adBL = new AdminBL();
            usDTO = new UserDTO();
        }

        private void AdminMainGUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!(txt_UserID.Text == "" || txt_Password.Text == "" || txt_Name.Text == ""))
            {
                
                string message = "Do you want to create account";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result==DialogResult.Yes)
                {
                    usDTO.UserID = txt_UserID.Text;
                    usDTO.Password = txt_Password.Text;
                    usDTO.Name = txt_Name.Text;
                    usDTO.Role = cmb_Role.Text;
                    usDTO.Address = txt_Address.Text;
                    usDTO.Phone = txt_Phone.Text;
                    adBL.CreateAcount(usDTO);
                    MessageBox.Show("Account Created");
                    txt_UserID.Text="";
                    txt_Password.Text="";
                    txt_Name.Text="";
                    cmb_Role.Text="";
                    txt_Address.Text="";
                    txt_Phone.Text="";
                    txt_UserID.Focus();
                }
                else if(result==DialogResult.No)
                {
                    button1.Focus();
                }

            }
        }

        private void cmb_Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
