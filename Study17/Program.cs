using System;
namespace Study17
{
    class Program
    {
        //C# 구조체
        //클래스와 비슷하지만, 값 타입(Value Type)이며 가볍고 빠름
        //주로 간단한 데이터 묶음을 만들 때 사용

        struct Point
        {
            //public은 어디서든 사용 가능한 권한
            //private은 나만 사용 할 수 있는 권한
            public int X;
            public int Y;

            //생성자 정의 : 처음 생성할 때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }
        }

        static void Main(string[] args)
        {
            Point p; //구조체 선언 (초기화 필요)
            p.X = 10;
            p.Y = 20;

            p.Print();
            
        }
    }
}
