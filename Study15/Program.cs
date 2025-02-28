using System;

namespace Study15
{
    class Program
    {
        static int AddArrow(int a, int b) => a + b;
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        static void Main(string[] args)
        {
            //화살표 함수 (람다 표현식)
            //중괄호와 return 생략가능
            Console.WriteLine(AddArrow(4,10));
            PrintMessageArrow();
        }
    }
}