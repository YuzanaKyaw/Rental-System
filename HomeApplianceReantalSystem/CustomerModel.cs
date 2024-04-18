using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceReantalSystem
{
    class CustomerModel : PersonModel
    {
        private string _Address, _PhoneNo;
        public string Address
        {
            set { _Address = value; }
            get { return _Address; }
        }
        public string PhoneNo
        {
            set { _PhoneNo = value; }
            get { return _PhoneNo; }
        }
    }
}
