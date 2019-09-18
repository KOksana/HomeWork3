using System;

namespace HomeWork3.HomeTask3
{
    class ElectricStove : ICooktop, IOven
    {
        public void Cook()
        {
            Console.WriteLine("ElectricStove cook");
        }

        public void Bake()
        {
            Console.WriteLine("ElectricStove bake");
        }
    }
}