using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devmetal.td.Core
{
    public class State : Module
    {
        public bool IsActive { get; set; }
        public bool IsLoaded { get; set; }

        public StateManager StateManager { get;  internal set; }

        public State()
        {

        }

        public virtual void Enter() { }
        public virtual void Leave() { }
    }
}
