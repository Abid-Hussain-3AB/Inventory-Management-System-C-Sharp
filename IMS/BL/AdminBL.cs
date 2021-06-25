using IMS.DL;
using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    class AdminBL
    {
        private AdminDL adDL;

        public AdminBL()
        {
            adDL = new AdminDL();
        }
        public void CreateAcount(UserDTO usDTO)
        {
            adDL.CreateAcountDB(usDTO);
            if(usDTO.Role=="Employee")
            {
                adDL.AddEmployeeInDB(usDTO);
            }
            if(usDTO.Role=="Visitor")
            {
                adDL.AddVisitorInDB(usDTO);
            }
            if(usDTO.Role=="Supplier")
            {
                adDL.AddSupplierInDB(usDTO);
            }
           
        }
    }
}
