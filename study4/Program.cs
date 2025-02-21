using System;

namespace study4
{
    class Program
    {
        static void Main(string[] arg)
        {
            // //문자열
            // string greeting; //문자열 변수를 선언
            // greeting = "Hello, World";

            // //변수의 값을 사용
            // Console.WriteLine(greeting);

            // int score = 100; //정수 선언 + 초기화
            // double temperature = 36.5;
            // string city = "Seoul";

            // //변수 출력
            // Console.WriteLine(score);
            // Console.WriteLine(temperature);
            // Console.WriteLine(city);

            //같은 데이터 타입의 변수를 쉼표로 구분해서 선언
            // int x = 10, y = 20, z = 30;

            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);

            // const double Pi = 3.141592; // 상수 double 변수가 아니라 상수임.
            // const int MaxScore = 100;

            // //출력
            // Console.WriteLine($"Pi : {Pi}");
            // Console.WriteLine($"Max Score : {MaxScore}");

            int atk = 16755, MaxHp = 78103, Cri = 36, Spec = 1017,
            a = 41, b = 611, c = 22, d = 39;

            Console.WriteLine($"공격력 {atk}");
            Console.WriteLine($"최대 생명력 {MaxHp}");
            Console.WriteLine($" ");
            
            Console.WriteLine($"치명 {Cri}");
            Console.WriteLine($"특화 {Spec}");
            Console.WriteLine($"제압 {a}");
            Console.WriteLine($"신속 {b}");
            Console.WriteLine($"인내 {c}");
            Console.WriteLine($"숙련 {d}");
        }
    }
}