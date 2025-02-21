using System;

namespace study3
{
    class program
    {
        static void Main(string[] arg)
        {
            //리터럴 : 코드에서 고정된 값을 의미한다.
            int hp = 100;
            double atk = 56.7;
            char rank = 'S';
            string name = "??";

            Console.WriteLine($"hp :{hp}");
            Console.WriteLine($"att : {atk}");
            Console.WriteLine($"캐릭터 이름 :{name}");
            Console.WriteLine($"등급 : {rank}");
        }
    }
}