namespace ConstructorsDemo
{
    class ConstructorsDemo
    {
        static int y;
        int x;
        static ConstructorsDemo()
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
