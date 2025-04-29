using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_15_bonus_02_car_simulator
{
    class Car
    {
        private Engine _engine;
        // Тут має бути код для поля Speed
        private int _speed = 0;
        public int Speed
        {
            get
            {
                return _speed;
            }
            private set
            {
                if (value > 180)
                {
                    value = 180;
                }
                else if(value < 0)
                {
                    value = 0;
                }else
                {
                    _speed = value;
                }
            }
        }

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public void IncreaseSpeed()
        {
            // Додати тут код
            Speed += _engine.BaseSpeed;
        }

        public void DecreaseSpeed()
        {
            // Додати тут код
            Speed -= _engine.BaseSpeed;
        }
    }
}
