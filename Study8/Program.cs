using System;
using System.Security.Cryptography.X509Certificates;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            //두 값을 비교하여 관계를 평가한다.
            // == 같다 != 같지 않다 a < b c > d <= =>

        //     int x = 5, y = 10;

        //     Console.WriteLine(x == y); //FALSE
        //     Console.WriteLine(x != y); //TRUE
        //     Console.WriteLine(x > y); //FALSE
        //     Console.WriteLine(x < y); //TRUE
        //     Console.WriteLine(x >= y); //FALSE
        //     Console.WriteLine(x <= y); //TRUE

        //논리 연산자

            // bool a = true;
            // bool b = false;

            // //and 연산
            // Console.WriteLine(a && b); // 1 and 0이라서 false
            // //or 연산
            // Console.WriteLine(a || b); // 1 or 0이라서 true
            // //not 연산
            // Console.WriteLine(!b); //!false 라서 true

            //비트연산자
            // int x = 5; //0101
            // int y = 3; //0011

            // Console.WriteLine(x & y); //and : 1 (0001)
            // Console.WriteLine(x | y); //or : 7 (0111)
            // Console.WriteLine(x ^ y); //xor : 6 (0110)
            // Console.WriteLine(~x); //not : -6

            // int value = 4; //0100

            // Console.WriteLine(value <<1); //비트가 왼쪽으로 이동 : 8(1000)
            // Console.WriteLine(value >>1); //비트가 오른쪽으로 이동 : 2(0010)

            // int a = 10, b = 20;

            // int max;

            // max = (a < b) ? a : b; //삼항 연산자

            // Console.WriteLine(max); //(비교) ? 참 : 거짓 ;

            // int key = 1;

            
            // string str = (key == 1) ? "문이 열렸습니다." : "문을 못열었습니다.";

            // Console.WriteLine(str);

            // int result = 10 + 2 * 5;
            // Console.WriteLine(result); //20
            // int adjustedResult = (10+2) *5;
            // Console.WriteLine(adjustedResult); // 60

            // int score = 85;

            // if(score >= 90)
            // {
            //     Console.WriteLine("A 학점");
            // }
            // else
            // {
            //     Console.WriteLine("B 학점");
            // }

            // string GameID = "멋사검존";

            // if(GameID == "멋사검존")
            // {
            //     Console.WriteLine("아이디가 일치합니다.");
            // }
            // else
            // {
            //     Console.WriteLine("아이디가 일치하지 않습니다.");
            // }

            // int score = 75;

            // if(score >= 90)
            // {
            //     Console.WriteLine("A 학점");
            // }
            // else if(score >= 80)
            // {
            //     Console.WriteLine("B 학점");
            // }
            // else if(score >= 70)
            // {
            //     Console.WriteLine("C 학점");
            // }
            // else
            // {
            //     Console.WriteLine("F 학점");
            // }

            //step1
            //가지고 있는 소지금을 입력하세요 : 
            //0~100 인피 + 1
            //101~200 카타나 + 2
            //201~300 진은검 + 3
            //301~400 집판검 + 4
            //401~500 엑스칼리버 + 5
            //501~600 유령검 + 6
            //601~ 전설의검 + 7

            //step2
            //캐릭터 이름
            //무기 이름
            //공격력 : 100 + 1

            // int gold = 0;
            // int atk = 0;

            // Console.Write("가지고 있는 소지금을 입력하세요 : ");
            // gold = int.Parse(Console.ReadLine());

            // if (gold <= 100)
            // {
            //     Console.WriteLine("무한의 대검");
            //     atk += 1;
            // }
            // else if (gold <= 200)
            // {
            //     Console.WriteLine("카타나");
            //     atk += 2;
            // }
            // else if (gold <= 300)
            // {
            //     Console.WriteLine("진은검");
            //     atk += 3;
            // }
            // else if (gold <= 400)
            // {
            //     Console.WriteLine("집판검");
            //     atk += 4;
            // }
            // else  if (gold <= 500)
            // {
            //     Console.WriteLine("엑스칼리버");
            //     atk += 5;
            // }
            // else  if (gold <= 600)
            // {
            //     Console.WriteLine("유령검");
            //     atk += 6;
            // }
            // else 
            // {
            //     Console.WriteLine("전설의 검");
            //     atk += 7;
            // }
            // Console.WriteLine("=========2단계===========");
            // Console.WriteLine("캐릭터 : 멋사검존");
            // Console.WriteLine($"공격력 100 + {atk}");
        }
    }
}