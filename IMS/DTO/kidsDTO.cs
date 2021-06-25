using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class kidsDTO
    {
        private string _itemID;
        private String _itemtype;
        private String _itemname;
        private String _itemprice;
        private String _itemRemaining;
         

        public kidsDTO()
        {

        }

        public string ItemId { get => _itemID; set => _itemID = value; }

        public string ItemName { get => _itemname; set => _itemname = value; }
        public string Itemtype { get => _itemtype; set => _itemtype = value; }
        
        public string Itemprice { get => _itemprice; set => _itemprice = value; }

        public string Itemremain { get => _itemRemaining; set => _itemRemaining = value; }





    }
}
