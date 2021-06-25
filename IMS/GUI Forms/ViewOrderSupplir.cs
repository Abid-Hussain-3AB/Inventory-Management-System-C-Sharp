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

namespace IMS.GUI_Forms
{
    
    public partial class ViewOrderSupplir : Form
    {
        private SupplirDTO SDTO;
        EmployeeBL emBL;
        public ViewOrderSupplir()
        {
            InitializeComponent();
            SDTO = new SupplirDTO();
            emBL = new EmployeeBL();
        }

        private void dgv_OrderSupplir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewOrderSupplir_Load(object sender, EventArgs e)
        {
            dgv_OrderSupplir.DataSource = emBL.ViewSupplirData();
            
        }
    }
}
