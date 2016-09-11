using System;
using System.Linq;

namespace Penguin
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string s;
            int[] count = new int[3];
            for (int i = 0; i < int.Parse(n); i++)
            {
                s = Console.ReadLine();
                if (s == "Emperor Penguin")
                    count[0]++;
                if (s == "Little Penguin")
                    count[1]++;
                if (s == "Macaroni Penguin")
                    count[2]++;
            }
            
            if (count[0] == count.Max())
                Console.WriteLine("Emperor Penguin");
            if (count[1] == count.Max())
                Console.WriteLine("Little Penguin");
            if (count[2] == count.Max())
                Console.WriteLine("Macaroni Penguin");

        }

    }
}

