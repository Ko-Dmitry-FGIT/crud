using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class ActorVM
    {
        private Actor _actor;
        public ActorVM(Actor actor)
        {
            _actor = actor;
        }
        public string Name
        {
            get
            {
                return _actor.Name;
            }
            set
            {
                _actor.Name = value;
            }
        }
        public string Sex
        {
            get
            {
                return _actor.Sex;
            }
            set
            {
                _actor.Sex = value;
            }
        }
        public int Birthdate
        {
            get
            {
                return _actor.Birthdate;
            }
            set
            {
                _actor.Birthdate = value;
            }
        }
    }
}
