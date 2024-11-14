namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 1;
            int c = 6;
            int d = 7;
            int i = 1;
            do
            {
                b++;
                b = a - c;
                c = b - a;
                d = (a + c) - i;
                i++;
            } while (i < 4);
            Console.WriteLine(d);




        }
    }
}
