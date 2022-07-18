using System;

namespace PP0601B
{
    class Machine
    {

        public void work(int n, int x, int y)
        {
            string line = "";
            for (int i = 1; i < n; i++)
            {
                if (i % x == 0)
                {
                    if (i % y != 0)
                    {
                        line += i + " ";
                    }
                }
            }
            Console.WriteLine(line);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine();
            string line = "";
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i ++)
            {
                line = Console.ReadLine();
                string[] orders = line.Split(" ");
                machine.work(int.Parse(orders[0]), int.Parse(orders[1]), int.Parse(orders[2]));

            }

        }
    }
}
