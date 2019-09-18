using System;

namespace HomeWork3.HomeTask3
{
    class Task3
    {
        public static void Processing()
        {
            var gasCooktop = new GasCooktop();
            var electronicCooktop = new ElectricCooktop();

            Console.WriteLine("-- Cooking surfaces can cook:");
            gasCooktop.Cook();
            electronicCooktop.Cook();

            var gasOven = new GasOven();
            var electricOven = new ElectricOven();

            Console.WriteLine("--- Ovens can bake:");
            gasOven.Bake();
            electricOven.Bake();

            var gasStove = new GasStove();
            var electricStove = new ElectricStove();

            Console.WriteLine("--- Stoves can cook and bake:");
            gasStove.Cook();
            gasStove.Bake();
            electricStove.Cook();
            electricStove.Bake();
        }
    }
}