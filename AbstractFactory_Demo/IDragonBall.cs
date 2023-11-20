using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Demo
{
        // Abstract Product A: Dragon Ball
        public interface IDragonBall
        {
            void DisplayInfo();
        }

        public class OneStarDragonBall : IDragonBall
        {
            public void DisplayInfo()
            {
                Console.WriteLine("One-Star Dragon Ball: Grants one wish when gathered with other six.");
            }
        }

        public class TwoStarDragonBall : IDragonBall
        {
            public void DisplayInfo()
            {
                Console.WriteLine("Two-Star Dragon Ball: Possesses unique abilities when combined.");
            }
        }

        public class ThreeStarDragonBall : IDragonBall
        {
            public void DisplayInfo()
            {
                Console.WriteLine("Three-Star Dragon Ball: Gives stregth and makes you fly.");
            }
        }

        public class FourStarDragonBall : IDragonBall
        {
            public void DisplayInfo()
            {
                Console.WriteLine("Four-Star Dragon Ball: Gives the power of 100 warriors.");
            }
        }
        
        public class FiveStarDragonBall : IDragonBall
        {
            public void DisplayInfo()
            {
                Console.WriteLine("Five-Star Dragon Ball: Gives accesss to Ki of all lives on earth");
            }
        }
        // Abstract Product B: Capsule
        public interface ICapsule
        {
            IDragonBall CreateDragonBall();
        }

        public class OneStarCapsule : ICapsule
        {
            public IDragonBall CreateDragonBall()
            {
                return new OneStarDragonBall();
            }
        }

        public class TwoStarCapsule : ICapsule
        {
            public IDragonBall CreateDragonBall()
            {
                return new TwoStarDragonBall();
            }
        }

        public class ThreeStarCapsule : ICapsule
        {
            public IDragonBall CreateDragonBall() 
            {
                return new ThreeStarDragonBall();
            }
        }

        public class FourStarCapsule : ICapsule
        {
            public IDragonBall CreateDragonBall()
            {
                return new FourStarDragonBall();
            }
        }

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
