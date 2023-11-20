using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Demo
{
    public class Program
    {
        // Abstract Product A: Dragon Ball
        public interface IDragonBall
        {
            void DisplayInfo();
        }

        // Concrete Products: Different types of Dragon Balls
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

        

    }
}
