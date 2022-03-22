using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class RolesVM
    {
        public Roles _role;
        public RolesVM(Roles role)
        {
            _role = role;
        }
        public string Id_actor
        {
            get
            {
                DataProvider dp = new DataProvider();
                return dp.GetActorById(_role.Id_actor);
            }
            set
            {
                Id_actor = value;
            }
        }
        public string Id_movie
        {
            get
            {
                DataProvider dp = new DataProvider();
                return dp.GetMovieById(_role.Id_movie);
            }
            set
            {
                Id_movie = value;
            }
        }
        public string Name
        {
            get
            {
                return _role.Name;
            }
            set
            {
                _role.Name = value;
            }
        }
    }
}
