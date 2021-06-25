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
    public partial class Visitor : Form
    {
        private VisitorBL vsBL;
        public Visitor()
        {
            InitializeComponent();
            vsBL = new VisitorBL();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
        }

        private void Visitor_Load(object sender, EventArgs e)
        {
            dgv_Food.DataSource = vsBL.ViewFood();
            dgv_Beauty.DataSource = vsBL.ViewBeauty();
            dgv_Gaming.DataSource = vsBL.ViewGaming();
            dgv_Kids.DataSource = vsBL.ViewKids();
           
           
        }
    }
}
