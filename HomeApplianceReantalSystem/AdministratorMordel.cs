using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApplianceReantalSystem
{
    class AdministratorMordel: PersonModel
    {
        private string _Role;
        public string Role
        {
            set { _Role = value; }
            get { return _Role; }
        }
    }
}
