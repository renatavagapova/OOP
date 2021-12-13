using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6._1_test
{
    public class Bicycle : Vehicle
    {
        /// <summary>
        /// Звонить
        /// </summary>
        public void RingBell()
        {
            Console.WriteLine("Ring!");
        }

        public override void Indicate(bool turningLeft)
        {
            base.Indicate(turningLeft);

            if (turningLeft)
                Console.WriteLine("Raising left arm");
            else
                Console.WriteLine("Raising right arm");
        }
    }
}
