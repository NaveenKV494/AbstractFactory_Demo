using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactory_Demo.IDragonBall;

namespace AbstractFactory_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ICapsule oneStarCapsule = new OneStarCapsule();
            DragonBallCollector collector = new DragonBallCollector(oneStarCapsule);
            collector.GatherDragonBalls();

            ICapsule twoStarCapsule = new TwoStarCapsule();
            collector = new DragonBallCollector(twoStarCapsule);
            collector.GatherDragonBalls();

            ICapsule threeStarCapsule = new ThreeStarCapsule();
            collector = new DragonBallCollector(threeStarCapsule);
            collector.GatherDragonBalls();

            ICapsule fourStarCapsule = new FourStarCapsule();
            collector = new DragonBallCollector(fourStarCapsule);
            collector.GatherDragonBalls();

            Console.ReadLine();
        }
    }
}
