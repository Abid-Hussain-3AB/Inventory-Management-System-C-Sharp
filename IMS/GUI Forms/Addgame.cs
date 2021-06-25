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
    public partial class Addgame : Form
    {
        gameDTO gDTO;
        EmployeeBL emBL;
        public Addgame()
        {
            InitializeComponent();
            gDTO = new gameDTO();
            emBL = new EmployeeBL();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (!(txt_game_ID.Text == ""))
            {
                string message = "Do you want to Add Item";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    gDTO.ItemID1 = txt_game_ID.Text;
                    gDTO.Itemtype = txt_game_type.Text;
                    gDTO.Itemcompany1 = txt_game_comp.Text;
                    gDTO.Itemprice1 = txt_game_price.Text;
                    gDTO.ItemRemaining = txt_game_rem.Text;

                    emBL.Addgame(gDTO);
                    MessageBox.Show("Item Added");
                    txt_game_ID.Text = " ";
                    txt_game_type.Text = " ";
                    txt_game_comp.Text = " ";
                    txt_game_price.Text = " ";
                    txt_game_rem.Text = " ";


                    var Mform = new Employee();
                    Mform.Show();
                }

            }

        }

        private void Addgame_Load(object sender, EventArgs e)
        {

        }




    }
}


