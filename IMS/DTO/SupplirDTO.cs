using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.DTO
{
    class SupplirDTO
    {
        private string _itemName;
        private string _CompanyName;
        private int _Quantity;

        public SupplirDTO()
        {
        }

        public string ItemName { get => _itemName; set => _itemName = value; }
        public string CompanyName { get => _CompanyName; set => _CompanyName = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
    }
}
