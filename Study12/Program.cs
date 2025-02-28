using System;

namespace Study12
{
    class Program
    {
        //전역변수
        static int number = 20;
        //1. 매개 변수도 반환 값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("안녕하세요");
        }

        //2. 매개 변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3. 반환값만 있는 함수
        static int GetNumber()
        {
            return 42;
        }

        //4. 매개변수와 반환값이 있는 함수
        static int Add(int x, int y)
        {
            return x + y;
        }

        //5. 기본값을 가진 매개변수 (디폴트 매개변수)
        static void Greet(string name = "손님")
        {
            Console.WriteLine($"안녕하세요, {name}");
        }

        //6. 함수 오버로딩(Overloading)
        //F12로 오버로드 확인
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        /// <summary>
        /// 두수를 곱하는 함수
        /// </summary>
        /// <param name="a">int,double 오버로딩해놈</param>
        /// <param name="b">int,double 오버로딩해놈</param>
        /// <returns></returns>
        static double Multiply(double a, double b)
        {
            return a * b;
        }

        //7. out 키워드 (여러 값을 반환 할 때)
        static void Divide(int a,int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //8.ref 키워드 (값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }
        static void Main(string[] args)
        {
            // PrintHello();
            // PrintMessage("반갑습니다.");
            // Console.WriteLine(GetNumber());
            // Console.WriteLine(number);
            // Console.WriteLine(Add(10, 20));
            // Greet();
            // Greet("지원");
            // Console.WriteLine(Multiply(3,4));
            // Console.WriteLine(Multiply(3.12,45.6));
            // int g,r;
            // Divide(10, 3, out g, out r);

            // Console.WriteLine($"목: {g},나머지 : {r}");
            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);
        }
    }
}