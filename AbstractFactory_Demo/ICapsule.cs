using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Demo
{
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
}
