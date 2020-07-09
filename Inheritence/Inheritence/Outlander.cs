using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritence
{
    class Outlander : Car
    {
        private int roadServiceMonths;

        public Outlander(int roadServiceMonths)
            : base("Outlander", "4WD", 5, 5, 4, false)
        {
            this.roadServiceMonths = roadServiceMonths;
        }

        public void accelerate(int rate)
        {
            int newVelocity = getCurrentValocity() + rate;
            if(newVelocity == 0)
            {
                stop();
                changeGear(1);
            }
            else if(newVelocity >0 && newVelocity <= 10)
            {
                changeGear(1);
            }
            else if (newVelocity > 10 && newVelocity <= 20)
            {
                changeGear(2);
            }
            else if (newVelocity > 20 && newVelocity <= 30)
            {
                changeGear(3);
            }
            else
            {
                changeGear(4);
            }

            if(newVelocity > 0)
            {
                changeVelocity(newVelocity, getCurrentDirection());
            }
        }
    }
}
