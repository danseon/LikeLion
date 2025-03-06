using Hello; //네임 스페이스를 편하게 쓸 수 있다.

namespace Hello
{
    public class Say
    {
        public void SayHello()
        {
            Console.WriteLine("안녕하세요!");
        }
    }
}

namespace Study35
{
    class Program
    {
        static void Main(string[] args)
        {   //using hello로 Hello는 생략가능하다.
            Hello.Say sa = new Hello.Say(); //다른 네임스페이스의 클래스로 객체 만들기 
            sa.SayHello();
        }
    }
}