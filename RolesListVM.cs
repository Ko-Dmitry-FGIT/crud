using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class RolesListVM
    {
        public static RolesVM _selectedRole;
        public RolesListVM()
        {
            RolesList = new List<RolesVM>();
            DataProvider DataProvider = new DataProvider();
            List<Roles> rolesList = DataProvider.GetRolesList();
            foreach (Roles c in rolesList)
            {
                RolesList.Add(new RolesVM(c));
            }
            DataProvider.CloseConnection();
        }
        public List<RolesVM> RolesList
        {
            get; set;
        }
        public RolesVM SelectedRole
        {
            get
            {
                return _selectedRole;
            }
            set
            {
                _selectedRole = value;
            }
        }
    }
}
