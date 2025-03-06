using System.Security.Cryptography.X509Certificates;

namespace Study38
{
    class Program
    {
        //Ref 포인터개념 참조
        //메서드 ref,out
        static void Increase(ref int x)
        {
            x++;
            //reutrn을 하지 않아도 매개변수의 포인터에 접근해서 +하기 때문에 증가한 값이 나온다.
        }

        //out은 반환이 여러개 일 때 유용하다.
        static void OutFunc(int a, int b, out int x, out int y)
        {
            x = a;
            y = b;
            //2개 이상 
        }

        static void Main(string[] args)
        {
            //ref
            // int a = 10;
            // Increase(ref a); //int a의 주소값을 Increase 메서드에 전달한다.
            // Console.WriteLine(a); //return을 안받았는데도 ++가 작동한다.

            //out
            int a = 10;
            int b = 20;
            int x,y;

            OutFunc(a, b, out x, out y); //out으로 Return없이 바로 a와b를 x와y에 저장한다.
            Console.WriteLine(x +" "+ y);
        }
    }
}