using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class FoodDTO
    {
        private String _itemId;
        private String _itemtype;
        private String _itemName;
        private String _itemcompany;
        private String _itemprice;
        private String _itemweight;
        private String _mfgDate;
        private String _expDate;
        private String _itemremain;




        public FoodDTO()
        {

        }

        public string ItemId { get => _itemId; set => _itemId = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Itemtype { get => _itemtype; set => _itemtype = value; }
        public string Itemcompany { get => _itemcompany; set => _itemcompany = value; }
        public string Itemprice { get => _itemprice; set => _itemprice = value; }
        public string Itemweight { get => _itemweight; set => _itemweight = value; }
        public string ExpDate { get => _expDate; set => _expDate = value; }
        public string Itemremain { get => _itemremain; set => _itemremain = value; }
        public string MfgDate { get => _mfgDate; set => _mfgDate = value; }
    }
}
