using System;

//네임 스페이스
//클래스, 함수, 변수 이름이 충돌 하는것을 방지하기 위해 사용한다.
//

namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요! MyClass클래스의 sayHello함수입니다.");
        }
    }
}
namespace Study14
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요! Program클래스의 sayHello함수입니다.");
        }
        static void Main(string[] args)
        {
            dev1.MyClass.SayHello();
            SayHello();
        }
    }
}