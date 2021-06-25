using IMS.DL;
using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.BL
{
    class EmployeeBL
    {
        private EmployeeDL vsDL;

        public EmployeeBL()
        {
            vsDL = new EmployeeDL();
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

        public void Del_Items(AddItemsDTO adDTO)
        {
            vsDL.DelItemInDB(adDTO);
        }
        public void Del_Beauty(AddItemsDTO aDTO)
        {
            vsDL.DelIBeautyInDB(aDTO);
        }

        public void Del_kids (AddItemsDTO kDTO)
        {
            vsDL.DelkidsInDB(kDTO);
        }
        public void Del_games(AddItemsDTO gDTO)
        {
            vsDL.DelgamesInDB(gDTO);
        }

      public  void AddFood(FoodDTO fDTO)
        {
            vsDL.AddFoodInDB(fDTO);
        }

        public void Addbeauty(beautyDTO bDTO)
        {
            vsDL.AddbeautyInDB(bDTO);
        }

        public void AddKids(kidsDTO kDTO)
        {
            vsDL.AddKidsInDB(kDTO);
        }
        public void Addgame(gameDTO gDTO)
        {
            vsDL.AddgameInDB(gDTO);
        }
        public void OrderToSupplir(SupplirDTO SDTO)
        {
            vsDL.OrderSupplir(SDTO);
        }
        public DataTable ViewSupplirData()
        {
            return vsDL.ViewOrderInDB();
        }
        public void DelSupplierOrder(AddItemsDTO aDTO)
        {
            vsDL.DelSupplirOrderDB(aDTO);
        }
        public void AddAcceptedOrder(AcceptOrder ASDTO)
        {
            vsDL.ADAcceptedOrderDB(ASDTO);
        }
    }
}
