using System;

namespace firstDotNet
{
    class Program
    {
        static void Test() 
        {
            decimal a = 2.0M;
            for (int i = 0; i < 10; i++){
                Console.WriteLine(a);
                a *= a;
            }
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            Test();
        }
    }
}
