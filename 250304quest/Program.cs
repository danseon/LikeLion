using System.Text;

namespace _250304quest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // //문제 1번 클래스와 상속
            // // Warrior 클래스를 만들고 Name과 Score 속성을 추가하세요.
            // // Warrior Strength 속성을 추가하세요.
            // // Main 메서드에서 Warrior 객체를 생성하고, Name, Score, Strength 값을 설정한 후 출력하세요.//
            // Warrior player = new Warrior();
            // player.Name = "박용사";
            // player.Score = 100;
            // player.Strength = 100;

            // Console.WriteLine($"{player.Name} , {player.Score} , {player.Strength}"); 

            // 문제 2번 예외 처리
            // // 사용자에게 정수를 입력받고, 이를 int로 변환하는 프로그램을 작성하세요.
            // // 숫자로 변환할 수 없는 경우 FormatException을 처리하여 "올바른 숫자를 입력하세요!"라는 메시지를 출력하세요.
            // // 변환이 성공하면 입력한 숫자를 출력하세요.
            // string sNum;
            // Console.Write($"정수를 입력하세요 : ");
            // sNum = Console.ReadLine();
            // try
            // {
            //     int num = int.Parse(sNum);
            //     Console.WriteLine(num);
            // }
            // catch (FormatException ex)
            // {
            //     Console.WriteLine("올바른 숫자를 입력하세요!");
            // }

            // // 문제 3번 컬렉션 (List, Queue, Stack) 활용
            // // List<string>을 생성하고 "사과", "바나나", "포도"를 추가하세요.
            // // Queue<string>을 생성하고 "첫 번째 작업", "두 번째 작업", "세 번째 작업"을 추가하세요.
            // // Stack<int>을 생성하고 10, 20, 30을 추가한 뒤 하나씩 출력하세요.

            // List<string> fruit = new List<string>();
            // fruit.Add("사과");
            // fruit.Add("바나나");
            // fruit.Add("포도");

            // Queue<string> task = new Queue<string>();
            // task.Enqueue("첫 번째 작업");
            // task.Enqueue("두 번째 작업");
            // task.Enqueue("세 번째 작업");

            // Stack<int> dec = new Stack<int>();
            // dec.Push(10);
            // dec.Push(20);
            // dec.Push(30);

            // while(dec.Count > 0)
            // {
            //     Console.WriteLine(dec.Pop());
            // }

            // // 문제 4번 문자열 처리
            // // 사용자로부터 "Hello, C# World!" 같은 문자열을 입력받아, 다음을 수행하세요.
            // // 전체 문자열을 대문자로 변환
            // // "C#"을 "CSharp"으로 변경
            // // 문자열의 길이 출력

            // string input = "Hello, C# World!";
            // input = input.ToUpper(); //대문자로 변환
            // input = input.Replace("C#","CSharp"); //C#을 CSharp로 치환
            // Console.WriteLine(input);
            // Console.WriteLine(input.Length);

            // 문제 5번 LINQ 활용
            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; 배열이 주어질 때,
            // LINQ를 사용하여 짝수만 필터링하고 출력하세요.
            // LINQ를 사용하여 모든 숫자의 합을 구하고 출력하세요.

            // int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // var evenNumbers = numbers.Where(n => n % 2 == 0);
            // foreach (int n in evenNumbers)
            // {
            //     Console.WriteLine(n);
            // }

            // int sum = numbers.Sum();
            // Console.WriteLine(sum);

            // int num = int.Parse(Console.ReadLine());
            // for(int i = 1; i <10; i++)
            // {
            //     Console.WriteLine(i*num);
            // }
            // string s = "*";
            // for(int i = 0; i<4 ; i++)
            // {
            //     Console.WriteLine(s);
            //     s += "*";
            // }





        }
    }
    public class Warrior //워리어 클래스
        {
            public string Name {get; set;}
            public int Score {get; set;}
            public int Strength {get; set;}
        }
}