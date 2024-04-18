using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceReantalSystem
{
    class ApplianceCategoryModel
    {
        private string _CategoryID, _CategoryName;
        public string CategoryID
        {
            set { _CategoryID = value; }
            get { return _CategoryID; }
        }
        public string CategoryName
        {
            set { _CategoryName = value; }
            get { return _CategoryName; }
        }

    }
}
