using System;
using System.IO.Compression;

namespace quest
{
    class Program
    {
        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Length(string s)
        {
            return s.Length;
        }
        static int Com (int a, int b, int c)
        {
            int max = 0;
            
                if (a >= b && a >= c) //이게 더 직관적이다
                {
                    max = a;
                }
                else if (b >= a && b >= c)
                {
                    max = b;
                }
                else
                {
                    max = c;
                }
            return max;
        }
        static void Main(string[] args)
        {
            // //배열문제1 출력 : 크기가 5인 정수 배열을 만들고 10,20,30,40,50 값을 저장한후 출력 하세요
            // int [] Array = new int[5];
            // for (int i=0; i<5; i++)
            // {
            //     Array[i] = i*10+10;
            //     Console.Write(Array[i] + " ");
            // }

            // //배열문제2 합 : 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력
            // Console.Write("숫자 입력 : ");
            // int[] number = new int[5];
            // string input = Console.ReadLine();
            // string[] sInput = input.Split(" ");
            // int sum = 0;

            // for (int i = 0; i < 5; i++)
            // {
            //     number[i] = int.Parse(sInput[i]);
            //     sum += number[i];
            // }
            // Console.WriteLine(sum);

            // //배열문제3 최대값 : 정수 배열 {3,8,15,6,2}에서 가장 큰 값 출력
            // int[] num = new int[5] {3,8,15,6,2};
            // int Max = 0;

            // for (int i=0; i<num.Length; i++)
            // {
            //     if(num[i]>Max)
            //     {
            //         Max = num[i];
            //     }
            // }
            // Console.WriteLine("최대값 : " + Max);

            // //반복문문제4 출력 : 1부터 10까지 출력
            // for (int i=0; i<10; i++)
            // {
            //     Console.Write($"{i+1} ");
            // }

            // //반복문문제5 짝수출력 : while을 사용하여 짝수만 출력
            // int n = 1;
            // while (n<=10)
            // {
            //     if (n % 2 == 0)
            //     {
            //         Console.Write(n + " ");
            //     }
            //     n++;
            // }

            // //반복문문제6 foreach : foreach를 사용하여 배열 {1,2,3,4,5} 출력
            // int[] Array = {1,2,3,4,5};
            // foreach (int i in Array)
            // {
            //     Console.Write(i + " ");
            // }

            // // 함수문제7 더하기함수 : 두 정수를 입력받아 합을 반환하는 함수를 작성하세요.
            // Console.Write("첫 번째 정수를 입력 :");
            // int num1 = int.Parse(Console.ReadLine());
            // Console.Write("두 번째 정수를 입력 :");
            // int num2 = int.Parse(Console.ReadLine());

            // Console.WriteLine($"{num1}과 {num2}의 합은 {Add(num1, num2)} 입니다.");

            // // 함수문제8 문자열 길이 반환 함수 : 문자열 입력을 받아 길이를 반환하는 함수를 만드세요.
            // Console.Write("문자열 입력 :");
            // string s = Console.ReadLine();
            // Length(s);

            //함수문제9 가장 큰수 반환 함수 : 3개의 정수를 입력받아 가장 큰 값을 반환하는 함수 작성
            Console.WriteLine("첫 번째 정수 입력 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("두 번째 정수 입력 : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("세 번째 정수 입력 : ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"가장 큰 수 {Com(a,b,c)}");
        }
    }
}