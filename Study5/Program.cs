using System;
using System.Reflection.Metadata;

namespace study5
{
    class Program
    {
        static void Main(string[] arg)
        {
            // //숫자 데이터 형식
            // int integerNum = 10; //정수 데이터
            // float floatNum = 3.14f; //단정밀도 실수
            // double doubleNum = 3.141592; //배정밀도 실수

            // Console.Write(integerNum + "\n");
            // Console.Write(floatNum + "\n");
            // Console.Write(doubleNum);

            //정수 데이터형식 : 소수점이 없는 숫자
            // int intValue = -100; //4바이트 크기의 정수
            // long longValue = 1234567890L; //8바이트 크기의 정수
            
            // Console.WriteLine(intValue);
            // Console.WriteLine(longValue);

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            // sbyte signedByte = -50; //1바이트 크기
            // short signedShort = -32000; //2바이트 크기
            // int signedInt = -200000000; //4바이트 크기

            // Console.WriteLine(signedByte);
            // Console.WriteLine(signedShort);
            // Console.WriteLine(signedInt);

            //부호없는 정수 데이터 형식
            // byte unsignedByte = 255;
            // ushort unsignedShort = 65000;
            // uint unsignedInt = 4000000000;

            // Console.WriteLine(unsignedByte);
            // Console.WriteLine(unsignedShort);
            // Console.WriteLine(unsignedInt);

            //실수형 데이터 형식 : 소수점을 포함한 숫자를 표현
            // float singlePrecision = 3.14f;
            // double doublePrecision = 3.1415926535;
            // decimal highPrecision = 3.14159265351231251251251m;

            // Console.WriteLine(singlePrecision);
            // Console.WriteLine(doublePrecision);
            // Console.WriteLine(highPrecision);
            
            // 접미사 사용: 숫자의 데이터 형식을 명시
            // int integerValue = 100; // 기본 정수형 (int)
            // long longValue = 100L; // 정수형 (long)
            // float floatValue = 3.14f; // 실수형 (float)
            // double doubleValue = 3.14; // 기본 실수형 (double)
            // decimal decimalValue = 3.14m; // 고정밀도 실수형 (decimal)
            // Console.WriteLine(integerValue); // 출력: 100
            // Console.WriteLine(longValue); // 출력: 100
            // Console.WriteLine(floatValue); // 출력: 3.14
            // Console.WriteLine(doubleValue); // 출력: 3.14

            //char형식 : 단일 문자를 표현
            // char letter = 'A'; //문자 a 저장
            // char symbol = '#'; //특수 기호 저장
            // char number = '9'; //숫자 형태의 문자 저장(문자 '9', 숫자 9가 아니다.)

            // Console.Write(letter);
            // Console.Write(symbol);
            // Console.Write(number);

            // //string 형식 : 여러 문자를 저장
            // string greeting = "Hello World";
            // string name = "Alice";

            // Console.WriteLine(greeting);
            // Console.WriteLine(name);
            // Console.WriteLine(greeting + ' ' + name);

            //bool형식 : 참,거짓
            // bool isRunning = true;
            // bool isfalse = false;

            // Console.WriteLine(isRunning);
            // Console.WriteLine(isfalse);

            // const: 변하지 않는 값을 정의
            // const double Pi = 3.14159; // 원주율
            // const int MaxScore = 100; // 최대 점수
            // Console.WriteLine(Pi); // 출력: 3.14159
            // Console.WriteLine(MaxScore); // 출력: 100
            // // Pi = 3.14; // 오류! 상수 값은 변경할 수 없습니다.

            //닷넷 형식 : 기본 형식의 닷넷표현
            // Int32 number = 123; //int닷넷형식
            // System.String text = "Hello"; //string닷넷형식
            // System.Boolean flag = true;

            // Console.WriteLine(number);
            // Console.WriteLine(text);
            // Console.WriteLine(flag);

            //int 래퍼 형식의 메서드 활용
            int num = 123;

            string numberAsString = num.ToString();

            //bool 래퍼 형식
            bool flag = true;

            string flagAsString = flag.ToString();
            
            Console.WriteLine(numberAsString + " " +flagAsString);
        }
    }
}