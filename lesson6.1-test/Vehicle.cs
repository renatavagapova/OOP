using System;
using System.Collections.Generic;
using System.Text;

namespace lesson6._1_test
{
   
        public class Vehicle            //транспортное средство
        {
            private int _speed;
            public int Speed { get { return _speed; } }
            public void Accelerate(int mph)
            {
                _speed += mph;
            }
            public void Decelerate(int mph)
            {
                _speed -= mph;
            }


            /// <summary>
            /// Индикация поворота
            /// </summary>
            /// <param name="turningLeft"></param>
            public virtual void Indicate(bool turningLeft)
            {
                if (turningLeft)
                    Console.WriteLine("Turning left");
                else
                    Console.WriteLine("Turning right");
            }
        }
    
}
