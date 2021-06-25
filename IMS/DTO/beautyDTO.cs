using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class beautyDTO
    {
         
        private String _itemtype;
        private String _itemid;
        private String _itemName;
        private String _itemcompany;
        private String _itemprice;
        private String _itemremain;

        public beautyDTO()
        {

        }


        
        public string ItemName { get => _itemName; set => _itemName = value; }
        public string Itemtype { get => _itemtype; set => _itemtype = value; }
        public string Itemcompany { get => _itemcompany; set => _itemcompany = value; }
        public string Itemprice { get => _itemprice; set => _itemprice = value; }
         
        public string Itemremain { get => _itemremain; set => _itemremain = value; }
        public string Itemid { get => _itemid; set => _itemid = value; }
    }
}
