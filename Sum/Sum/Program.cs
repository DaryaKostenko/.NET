using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer=0;
            if (n>0)
                for (int i = 1; i <= n; i++)
                    answer+=i;
            else
                for (int i = n; i <= 1; i++)
                    answer += i;
            Console.WriteLine(answer);
        }
    }
}
