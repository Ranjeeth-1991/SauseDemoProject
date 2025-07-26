namespace ConstructorsDemo
{
    class ConstructorsDemo
    {
        static int y;
        int x; //a variable
        static ConstructorsDemo() //specific class
        {
            Console.WriteLine("Static Constructor is Called.");
        }
        public ConstructorsDemo()
        {
            Console.WriteLine("Non-Static Constructor is Called.");
        }
        static void Main()
            {

            }
    }
}
