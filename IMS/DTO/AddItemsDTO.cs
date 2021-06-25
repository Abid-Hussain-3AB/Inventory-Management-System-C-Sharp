using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class AddItemsDTO
    {
        private String _itemid;
     //   private String _itemName;

        public AddItemsDTO()
        {
            
        }
        public string ItemName { get => _itemid; set => _itemid = value; }
      //  public string ItemName { get => _itemName; set => _itemName = value; }
    }

}
