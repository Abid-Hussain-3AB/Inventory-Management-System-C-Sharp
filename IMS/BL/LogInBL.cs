using IMS.DL;
using IMS.DTO;
using IMS.GUI_Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS.BL
{
  
    class LogInBL
    {
        private LogInDL lgdl;

        public LogInBL()
        {
            lgdl = new LogInDL();
        }
        public Form verify(LogInDTO lg)
        {

            UserDTO udDTo = lgdl.VerifyUserFromDB(lg);
            if(udDTo ==null)
            {
                return new WrongGUI();
            }
            if (udDTo.Role == "admin")
            {
                return new AdminMainGUI();
            }
            else if(udDTo.Role=="Visitor")
            {
                return new Visitor(); 
            }
            else if (udDTo.Role == "Employee")
            {
                return new Employee();
            }
            else if (udDTo.Role == "Supplier")
            {
                return new SupplierOrders();
            }

            return new  WrongGUI();
        }
    }
}
