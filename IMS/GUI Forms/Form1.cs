using IMS.BL;
using IMS.DL;
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

namespace IMS
{
    public partial class Form1 : Form
    {
        private LogInDTO lgDTO;
        private LogInBL lgBL;

        private LogInDL lgdl;
        public Form1()
        {
            InitializeComponent();
            lgDTO = new LogInDTO();
            lgBL = new LogInBL();
            lgdl = new LogInDL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (!(txt_Username.Text == "" || txt_Password.Text == ""))
            {
                lgDTO.Username = txt_Username.Text;
                lgDTO.Password = txt_Password.Text;
                lgBL.verify(lgDTO).ShowDialog();


            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
            txt_Password.Text = "";
            txt_Username.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
