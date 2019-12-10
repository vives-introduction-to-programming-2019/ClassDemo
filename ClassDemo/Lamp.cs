using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class Lamp
    {
        // Attributes
        private bool state = false;

        public void on()
        {
            state = true;
        }

        public void off()
        {
            state = false;
        }

        public bool getState()
        {
            return state;
        }

        public override string ToString()
        {
            if (state)
            {
                return "The lamp is on";
            }
            else
            {
                return "The lamp is off";
            }
        }
    }
}
