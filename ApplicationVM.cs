using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class ApplicationVM
    {
        public ApplicationVM()
        {
            RolesListVM = new RolesListVM();
        }
        public RolesListVM RolesListVM
        {
            get; set;
        }
    }
}
