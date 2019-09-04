using System;

namespace HomeWork3.HomeTask2
{
    class Computer
    {
        private IInput _input;
        private IDisplay _display;
        private IProcessor _processor;

        public Computer(IInput input, IDisplay display, IProcessor processor)
        {
            _input = input;
            _display = display;
            _processor = processor;
        }

        public void Work()
        {
            Console.WriteLine("--- Computer is working ---");
            _input.GetInput();
            _display.Display();
            _processor.Process();
        }
    }
}