using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class ActorVMList
    {
        private ActorVM _selectedActor;
        public ActorVMList()
        {
            ActorList = new List<ActorVM>();
            DataProvider DataProvider = new DataProvider();
            List<Actor> actorList = DataProvider.GetActorList();
            foreach (Actor c in actorList)
            {
                ActorList.Add(new ActorVM(c));
            }
            DataProvider.CloseConnection();
        }
        public List<ActorVM> ActorList
        {
            get; set;
        }
        public ActorVM SelectedActor
        {
            get
            {
                return _selectedActor;
            }
            set
            {
                _selectedActor = value;
            }
        }

    }
}
