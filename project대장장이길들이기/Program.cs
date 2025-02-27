using System;

namespace smith
{
    class Program
    {
        static void Main (string[] args)
        {
            //랜덤 객체 생성
            Random random = new Random();

            Console.WriteLine("대장장이 키우기");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(1000); //1초 딜레이

            while(true) //무한루프
            {
                Console.Clear();
                Console.WriteLine("1. 나무캐기");
                Console.WriteLine("2. 장비뽑기");
                Console.WriteLine("3. 나가기");
                Console.Write("입력 : ");
                input = int.Parse(Console.ReadLine()); //명령 입력

                if(input == 1)
                {
                    while(true)
                    {
                        Console.WriteLine("나무캐기(Enter)");
                        Console.WriteLine("뒤로가기(x)");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금 : "+ pmoney);

                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");
                            break;
                        }
                    }
                }
                else if(input == 2)
                {
                    //장비뽑기
                    if(pmoney >= 1000)
                    {
                        pmoney -= 1000;
                        //20번 뽑기
                        for(int i = 1; i<=20; i++)
                        {
                            rnd = random.Next(1, 101);

                            if (rnd == 1) //1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rnd >=2 && rnd <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rnd >= 7 && rnd<= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rnd >= 18 && rnd<= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rnd >= 39 && rnd<= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            Thread.Sleep(300);
                        }
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }
                else if(input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}