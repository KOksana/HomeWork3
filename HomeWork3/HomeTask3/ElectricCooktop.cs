using System;

namespace HomeWork3.HomeTask3
{
    class ElectricCooktop : ICooktop
    {
        public void Cook()
        {
            Console.WriteLine("ElectricCooktop cook");
        }
    }
}