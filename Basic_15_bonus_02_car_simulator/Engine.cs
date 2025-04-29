using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_bonus_02_car_simulator
{
    class Engine
    {
        public int BaseSpeed { get; private set; }

        public Engine(int speed)
        {
            BaseSpeed = speed;
        }
    }
}
