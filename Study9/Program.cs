using System;

namespace Study9
{
    class Program
    {
        static void Main (string[] args)
        {
            // //switch문
            // int day = 1;
            // day = int.Parse(Console.ReadLine());

            // switch (day)
            // {
            //     case 1:
            //         Console.WriteLine ("월요일");
            //         break;
            //     case 2:
            //         Console.WriteLine ("화요일");
            //         break;
            //     case 3:
            //         Console.WriteLine ("수요일");
            //         break;
            //     case 4:
            //         Console.WriteLine ("목요일");
            //         break;
            //     case 5:
            //         Console.WriteLine ("금요일");
            //         break;
            //     default:
            //         Console.WriteLine("주말입니다.");
            //         break;

            //캐릭터를 선택하세요 (1.검사 2.마법사 3. 도적):
            //스위치문 이용
            //검 공100 방90
            //마 공 110 방 80
            //도적 공115 방70
            // int select = 0;

            // Console.Write("캐릭터를 선택하세요. (1.검사 2.마법사 3.도적) : ");
            // select = int.Parse(Console.ReadLine());
            // switch (select)
            // {
            //     case 1:
            //         Console.WriteLine("검사");
            //         Console.WriteLine("공격력 : 100");
            //         Console.WriteLine("방어력 : 90");
            //     break;

            //     case 2:
            //         Console.WriteLine("마법사");
            //         Console.WriteLine("공격력 : 110");
            //         Console.WriteLine("방어력 : 80");
            //     break;

            //     case 3:
            //         Console.WriteLine("도적");
            //         Console.WriteLine("공격력 : 115");
            //         Console.WriteLine("방어력 : 70");
            //     break;
            //     default:
            //         Console.WriteLine("1,2,3 중 하나를 입력하세요.");
                    
            //     break;

            // }

            //반복문
            //초기화;조건식;반복문;
            // for (int i = 1; i<=5; i++)
            // {
            //     Console.WriteLine("숫자 : " + i);
            // }

            //무한반복
            // for(;;)
            // {
            //     Console.WriteLine("중꺾마");
            // }

            //0부터 9까지 출력하기
            //for문 활용
            // for (int i = 0; i <10; i++)
            // {
            //     Console.WriteLine(i);
            // }
            // int sum = 0;

            // for(int i = 0; i <= 10; i++)
            // {
            //     sum += i;
            // }
            // Console.WriteLine(sum);

            // int cnt = 1; //초기화

            // while (cnt <= 5)
            // {
            //     Console.WriteLine ($"Count : {cnt}"); //조건식
            //     cnt++; //증감식

            //     if(cnt == 3)
            //     {
            //         Console.WriteLine("3일때 종료");
            //         break;
            //     }
            // }

            // //랜덤
            // Random rand = new Random(); //Random 객체를 생성한다.

            // //0이상 10미만의 랜덤 정수 생성
            // for(int i = 0; i<100; i++)
            // {
            // int randomNumber = rand.Next (0,10);
            // Console.WriteLine ("0이상 10 미만의 랜덤 정수 : " + randomNumber);
            // }

            //대장장이 키우기
            //도끼등급 sss 10%
            //도끼등급 ss  40%
            //도끼등급 s   50%

            // Random rand = new Random();

            // int rnd = 0;

            // for(int i = 0; i < 20; i++)
            // {
            //     rnd = rand.Next(1, 101); //1~100

            //     if (rnd >= 1 && rnd <=10)
            //     {
            //         Console.WriteLine("도끼등급 sss");
            //     }
            //     else if (rnd >= 11 && rnd <=40)
            //     {
            //         Console.WriteLine("도끼등급 ss");
            //     }
            //     else
            //     {
            //         Console.WriteLine("도끼등급 s");
            //     }
            //     Thread.Sleep(500);
            // }

            // int x = 5;

            // do{
            //     Console.WriteLine ("최소 한번은 실행된다.");
            //     x--;
            // } while(x > 0);

            //break문
            //반복문을 탈출 할 수 있다.

            // for(int i = 1; i<= 10; i++)
            // {
            //     if ( i == 5)
            //     {
            //         break;
            //     }

            //     Console.WriteLine(i);
            // }

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.

            // for(int i = 1; i <= 10; i++)
            // {
            //     if(i % 2 == 0) //짝수일 때 continue(스킵))
            //     {
            //         continue;
            //     }

            //     Console.WriteLine(i); //홀수만 출력
            // }

            //goto

            // int n = 1;

            // start: 
            // if(n <= 5)
            // {
            //     Console.WriteLine(n);
            //     n++;

            //     goto start; //레이블로 이동
            // }
            
             
        }
    }
}