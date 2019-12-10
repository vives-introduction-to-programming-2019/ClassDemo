using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDemo
{
    public class LedLamp
    {
        // Attributes
        private int brightness = 0;     // 0 - 100
        private bool state = false;

        public void on()
        {
            state = true;
            if (brightness < 10)
            {
                brightness = 10;
            }
        }

        public void off()
        {
            state = false;
        }

        public void dim(int dimValue)
        {
            if (dimValue >= 0 && dimValue <= 100)
            {
                brightness = dimValue;
            }
            else if (dimValue < 0)
            {
                brightness = 0;
            }
            else if (dimValue > 100)
            {
                brightness = 100;
            }
        } 

        public override string ToString()
        {
            if (state && brightness > 0)
            {
                return $"The lamp is on @ {brightness}";
            }
            else
            {
                return $"The lamp is off";
            }
        }
    }
}
