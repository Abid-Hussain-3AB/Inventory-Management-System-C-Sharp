using IMS.BL;
using IMS.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.DTO
{
    class gameDTO
    {

        private String _itemtype;
        private String ItemID;
        private String Itemcompany;
        private String _itemRemaining;
        private String Itemprice;

        public gameDTO()
        {
        }

        public string ItemRemaining { get => _itemRemaining; set => _itemRemaining = value; }

        public string Itemtype { get => _itemtype; set => _itemtype = value; }
        public string ItemID1 { get => ItemID; set => ItemID = value; }
        public string Itemcompany1 { get => Itemcompany; set => Itemcompany = value; }
        public string Itemprice1 { get => Itemprice; set => Itemprice = value; }
    }


}
