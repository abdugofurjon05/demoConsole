namespace ConsoleApp1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Did();
            FileName.Nothing();
            Console.WriteLine(add(1,2));



            Console.ReadKey();
        }

        public static int add(int a, int b) => a + b;





        public static void Did()
        {
            Console.WriteLine("did");
        }


    }
}