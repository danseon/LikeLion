using System;

namespace Study13
{
    class Program
    {
        //param 키워드 (가변 매개변수)
        // static int Sum(params int[] numbers)
        // {
        //     int total = 0;

        //     foreach (int num in numbers)
        //     {
        //         total = total + num;
        //     }

        //     return total;
        // }

        //재귀함수(자기자신을 호출)
        static int Factorial(int n)
        {
            if (n <= 1) return 1; //출력 + 탈출(아래로 내려가서 재귀하지않고)

            return n * Factorial(n - 1);
        }
        static void Main(string[] args)
        {
            // Facotorial(5) = 5*4*3*2*1 = 120 return 5*4*3*2*1
            Console.WriteLine(Factorial(5));

        }
    }
}