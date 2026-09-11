using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("I am a robot duck!");
        }
    }


}
