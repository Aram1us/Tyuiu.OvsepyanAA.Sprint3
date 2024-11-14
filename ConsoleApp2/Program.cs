namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;
            int sumd = 0;
            for (x = 4; x <= 8; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0)
                    {
                        if (d > 4)
                        {
                            {
                                sumd = sumd + d;
                            }
                        }
                    }
                }
            }
                Console.WriteLine(sumd);

            }
        }
    }


