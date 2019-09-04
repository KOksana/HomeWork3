namespace HomeWork3.HomeTask2
{
    public class Task2
    {
        public static void Processing()
        {
            Computer computer1 = new Computer(new Joystick(), new BuiltInDisplay(), new Amd64Processor());
            computer1.Work();

            Computer computer2 = new Computer(new Keyboard(), new ExternalDisplay(), new ArmProcessor());
            computer2.Work();

            Computer computer3 = new Computer(new Mouse(), new Projector(), new Amd64Processor());
            computer3.Work();
        }
    }
}