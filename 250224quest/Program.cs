using System;

namespace quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // // 문제 1. 세 정수의 최대값 구하기
            // // 문제 설명:
            // // 사용자로부터 3개의 정수를 입력받아 그 중 가장 큰 값을 출력하는 프로그램을 작성하세요.
            // // 요구사항:

            // // 사용자에게 세 개의 정수를 입력받습니다.
            // // if문을 사용하여 가장 큰 정수를 결정합니다.
            // // 결과를 “최대값: X” 형식으로 출력합니다.

            // int a = 0 , b = 0 , c = 0 , max = 0;
            // Console.Write("첫 번째 정수를 입력하세요 : ");
            // a = int.Parse(Console.ReadLine());
            // Console.Write("두 번째 정수를 입력하세요 : ");
            // b = int.Parse(Console.ReadLine());
            // Console.Write("세 번째 정수를 입력하세요 : ");
            // c = int.Parse(Console.ReadLine());

            // if (a>b && a>c)
            // {
            //     max = a;
            // }
            // else if (b>c && b>c)
            // {
            //     max = b;
            // }
            // else
            // {
            //     max = c;
            // }
            // Console.WriteLine($"가장 큰 수는{max}입니다.");
        

            // // 문제 2. 점수에 따른 학점 평가
            // // 문제 설명:
            // // 학생의 점수를 입력받아 아래 기준에 따라 학점을 출력하는 프로그램을 작성하세요.

            // // 90 이상: A 학점
            // // 80 이상 90 미만: B 학점
            // // 70 이상 80 미만: C 학점
            // // 60 이상 70 미만: D 학점
            // // 60 미만: F 학점 0
            
            // int score = 0;
            // string rank = "";

            // Console.Write("점수를 입력하세요 : ");
            // score = int.Parse(Console.ReadLine());
            // if (score >= 90)
            // {
            //     rank = "A";
            // }
            // else if (score >= 80)
            // {
            //     rank = "B";
            // }
            // else if (score >= 70)
            // {
            //     rank = "C";
            // }
            // else if (score >= 60)
            // {
            //     rank = "D";
            // }
            // else
            // {
            //     rank = "F";
            // }
            // Console.Write($"나의 학점은 {rank}입니다.");

            // 문제 3. 간단한 사칙연산 계산기
            // 문제 설명:
            // 사용자로부터 두 개의 숫자와 연산자(+, -, *, /)를 입력받아 해당 연산을 수행하고 결과를 출력하는 계산기 프로그램을 작성하세요.
            // 요구사항:

            // 두 개의 숫자와 연산자 기호를 입력받습니다.
            // if문을 사용하여 연산자를 확인하고 해당 연산을 수행합니다.
            // 나눗셈의 경우 0으로 나누는 상황을 처리하여 에러 메시지를 출력합니다.
            // 결과는 “결과: X” 형식으로 출력합니다.

            // int a = 0, b = 0;
            // string cal ;
            // Console.Write("첫 번째 수를 입력하세요");
            // a = int.Parse(Console.ReadLine());
            // Console.Write("연산기호를 입력하세요");
            // cal = Console.ReadLine();
            // Console.Write("두 번째 수를 입력하세요");
            // b = int.Parse(Console.ReadLine());

            // if (cal == "+")
            // {
            //     Console.WriteLine(a+b);
            // }
            // else if (cal == "-")
            // {
            //     Console.WriteLine(a-b);
            // }
            // else if (cal == "*")
            // {
            //     Console.WriteLine(a*b);
            // }
            // else if (cal == "/")
            // {               
            //     if (a * b == 0)
            //     {
            //         Console.Write("error");
            //     }
            //     else
            //     {
            //         Console.WriteLine(a/b);
            //     }
            // }
            int a = 0 , b = 0;
            string s = Console.ReadLine();
            string[] ss = s.Split(" ");
            a = int.Parse(ss[0]);
            b = int.Parse(ss[1]);
            Console.WriteLine(a+b);
        }
    }
}