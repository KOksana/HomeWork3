using System;
using HomeWork3.HomeTask3;
using HomeWork3.HomeTask2;

namespace HomeWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose task: 1 - Task1 (Library); 2 - Task2 (Interfaces); 3 - Task3 (hierarchy)");

            string inputValue = Console.ReadLine();
            if (int.TryParse(inputValue, out int taskNumber))
            {
                switch (taskNumber)
                {
                    case 1:
                        Task1.Processing();
                        break;
                    case 2:
                        Task2.Processing();
                        break;
                    case 3:
                        Task3.Processing();
                        break;
                    default:
                        Console.WriteLine("There are no task with this number");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input number");
                Console.Read();
            }
            Console.Read();
        }
    }
}
