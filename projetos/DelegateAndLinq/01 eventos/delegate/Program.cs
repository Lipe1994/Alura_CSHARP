using System;

namespace action
{
    class Program
    {
        delegate int OnRingToBell(int a, int b);
        static void Main(string[] args)
        {
            //setando função em um delegate de diferentes maneiras
            var onRingToBell1 = new OnRingToBell(sum);
            
            OnRingToBell onRingToBell2 = sum;

            OnRingToBell onRingToBell3 = (x, y)=> x+y;//essa técnica aqui usa lambda para usar funções anônimas...

            Console.WriteLine($"onRingToBell1: {onRingToBell1(5,2)}");
            Console.WriteLine($"onRingToBell2: {onRingToBell2(5,2)}");
            Console.WriteLine($"onRingToBell3: {onRingToBell3(5,2)}");


            Console.ReadKey();
        }

        static int sum(int x, int y) {
            return x + y; 
        }

    }
}
