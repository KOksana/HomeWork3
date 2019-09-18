using System;

namespace HomeWork3.HomeTask3
{
    class GasStove : ICooktop, IOven
    {
        public void Cook()
        {
            Console.WriteLine("GasStove cook");
        }

        public void Bake()
        {
            Console.WriteLine("GasStove bake");
        }
    }
}