using System;

namespace simpleExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            if((s2!=0)&&(s2!=1))
                Console.WriteLine(s1-s2*s3);
            else Console.WriteLine(s1-s2-s3);
        }
    }
}
