using IMS.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    class VisitorBL
    {
        private VisitorDL vsDL;

        public VisitorBL()
        {
            vsDL = new VisitorDL();
        }
        public DataTable ViewFood()
        {
            return vsDL.ViewFoodOnly();
        }
        public DataTable ViewBeauty()
        {
            return vsDL.ViewBeautyOnly();
        }
        public DataTable ViewKids()
        {
            return vsDL.ViewKidsOnly();
        }
        public DataTable ViewGaming()
        {
            return vsDL.ViewGamingOnly();
        }

    }
}
