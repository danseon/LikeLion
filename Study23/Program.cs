using System.Diagnostics;
using System.Text;

namespace Study23
{
    class Program
    {
        static void Main(string[] args)
        {
            // //값 형식과 참조 형식
            // //값 형식은 스택에 저장되고, 참조형식은 힙에 저장됩니다.

            // int valueType = 10;
            // object refernceType = valueType;

            // valueType = 20;
            // Console.WriteLine($"ValueType : {valueType}"); //20
            // Console.WriteLine($"ReferenceTypoe : {refernceType}"); //10

            // //박싱 언박싱
            // //값 형식을 참조형식으로 변환(박싱), 다시 값 형식으로 변환(언박싱)

            // int value = 42;
            // object boxed = value; //박싱
            // int unboxed = (int)boxed; //언박싱

            // Console.WriteLine($"Boxed: {boxed}, unboxed : {unboxed}");

            //is 연산자 형식 비교하기
            //객체가 특정 형식인지 확인할 수 있다.

            // object obj = "Hello";
            // Console.WriteLine(obj is string); //true
            // Console.WriteLine(obj is int); //false

            //as 연산자로 형식 변환하기
            //as 연산자를 사용해 안전하게 형 변환을 수행한다.

            // object obj = "Hello";
            // string str = obj as string; //string으로 변환

            // Console.WriteLine(str.GetType()); //string 나옴.

            // object obj = 42;
            // if(obj is int number)
            // {
            //     Console.WriteLine($"Number : {number}");
            // }
            // else
            // {
            //     Console.WriteLine("not");
            // }

            // string greeting = "Hello";
            // string name = "Alice";

            // string message = greeting + "," + name + "!";
            // Console.WriteLine(message);
            // Console.WriteLine($"Length of name : {name.Length}"); //문자열길이
            // Console.WriteLine($"ToUpper: {name.ToUpper()}"); //대문자 변환

            //string 다양한 메서드
            // string text = "C# is awesome!";
            // Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}");
            // Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}");
            // Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}");
            // Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}");

            // StringBuilder sb = new StringBuilder("Hello");
            // sb.Append(",");
            // sb.Append("World!");
            // Console.WriteLine(sb.ToString());

            //string과 stringbuilder클래스 성능차이 비교
            //반복적으로 문자열 수정할떄 효율적이다.

            // int iterations = 10000;
            // Stopwatch sw = Stopwatch.StartNew();
            // string text = "";
            // for (int i = 0; i < iterations; i++)
            // {
            //     text += "a";
            // }
            // sw.Stop();
            // Console.WriteLine($"String : {sw.ElapsedMilliseconds}");

            // sw.Restart();
            // StringBuilder sb = new StringBuilder();
            // for (int i = 0; i < iterations; i++)
            // {
            //     sb.Append("a");
            // }
            // sw.Stop();

            // Console.WriteLine($"stringBuilder : {sw.ElapsedMilliseconds}");

            //예외처리
            //예외는 프로그램 실행중 발생하는 오류입니다. 예외를 처리하면 프로그램이 중단되지않고
            //실행을 계속 할수있습니다.
            //Try catch
            // while (true)
            // {
            //     try
            //     {
            //         int[] numbers = { 1, 2, 3 };
            //         Console.WriteLine(numbers[5]);
            //     }
            //     catch (IndexOutOfRangeException ex)
            //     {
            //         Console.WriteLine($"Error : {ex.Message}");
            //     }
            // }

            //finally 블록은 예외 발생 여부와 상관없이 항상 실행됩니다.
            // while (true)
            // {
            //     try
            //     {
            //         int number = int.Parse("NotANumber"); //오류발생
            //     }
            //     catch (FormatException ex)
            //     {
            //         Console.WriteLine($"Format Error: {ex.Message}");
            //     }
            //     finally
            //     {
            //         Console.WriteLine("항상 실행되는 구문은 Finally");
            //     }
            // }

            //Exception 클래스
            //모든 예외의 기본 클래스
            // try
            // {
            //     int number = int.Parse("abc");
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"General Error : {ex.Message}");
            // }

            //throw 구문으로 직접 예외 발생시키기

            // try
            // {
            //     int age = -5;
            //     if (age < 0)
            //     {
            //         throw new ArgumentException("Age cannot be negative");
            //     }
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine($"Exception : {ex.Message}");
            // }

            
        }
    }
}