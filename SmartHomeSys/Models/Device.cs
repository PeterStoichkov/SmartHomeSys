using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHomeSys.Models
{
    abstract class Device : IDevice
    {
        private bool active;
        
        public virtual bool ReturnState()
        {
            return active;
        }

        public void TurnON()
        {
            active = true;
        }

        public void TurnOFF()
        {
            active = false;
        }
    }
}
