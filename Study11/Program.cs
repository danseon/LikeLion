using System;
using System.Net.Mail;

namespace Study11
{
    class Program
    {
        // //1단계 기본형
        // static void Loading()
        // {
        //     Console.WriteLine("로딩화면");
        // }
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //2단계
        //입력
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine("공격력은 :  "+ _Attack);
        }

        //3단계
        //출력
        static int BaseAttack()
        {
            //기본공격력 10
            int attack = 10;

            return attack; //attack값 반환
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            // int Attack = 0;
            // int bAttack = 0;
            // Console.WriteLine("캐릭터의 공격력을 입력 : ");
            // Attack = int.Parse(Console.ReadLine());

            // //기본공격력
            // bAttack = BaseAttack(); //기본 공격력 함수로 기본공격력값을 반환받았다.
            // AttackFunction(bAttack + Attack); // 입력된 attack과 기본공격력을 합쳐서 표시.

            //두 수를 더하는 함수를 만들어서 오류를 해결 하세요.
            // int result = Add(10, 20);
            // Console.WriteLine($"10 + 20 = {result}");

            // string[] fruits = {"사과","체리","바나나"};

            // //반복문
            // foreach(string fruit in fruits)
            // {
            //     Console.WriteLine(fruit);
            // }
        }
    }

}