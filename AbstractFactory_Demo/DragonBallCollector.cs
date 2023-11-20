using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Demo
{
    public class DragonBallCollector
    {
        private ICapsule _capsule;

        public DragonBallCollector(ICapsule capsule)
        {
            _capsule = capsule;
        }

        public void GatherDragonBalls()
        {
            IDragonBall dragonBall = _capsule.CreateDragonBall();
            Console.WriteLine("Gathering Dragon Balls...");
            dragonBall.DisplayInfo();
        }
    }
}
