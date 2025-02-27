using System;

namespace Study10;

class Program
{
    static void Main(string[] args)
    {
        // //배열
        // //0부터 시작한다

        // int[] num = new int[3]; // 3칸의 배열을 만들겠다. 3칸 메모리 할당
        // num[0] = 10;
        // num[1] = 20;
        // num[2] = 30;

        // Console.WriteLine(num[0]);
        // Console.WriteLine(num[1]);
        // Console.WriteLine(num[2]);

        // for(int i=0; i<3; i++)
        // {
        //     Console.WriteLine(num[i]);
        // }

        // int[] numbers = { 1 , 2 , 3 }; //간단한 선언과 초기화
        // int[] numbers2 = new int[3]; // 크기만 지정
        // int[] numbers3 = new int[] { 1, 2, 3}; //초기화와 함께 선언

        // for(int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine(numbers[i]);
        // }

        // string[] fruits = { "사과", "바나나", "오렌지"};

        // for(int i = 0; i < 3; i++)
        // {
        //     Console.WriteLine(fruits[i]);
        // }

        //3명의
        //국어,영어,수학 점수
        //총점과 평균을 출력하세요

        int[] iKor = new int[3];
        int[] iEng = new int[3];
        int[] iMath = new int[3];
        int[] sum = new int[3];
        float[] avg = new float[3];

        // //학생입력받기 + 총점 평균 저장
        // for(int i=0; i<3; i++)
        // {
        //     Console.WriteLine("학생 성적 입력하세요 : ");
        //     Console.Write("국어 : ");
        //     iKor[i] = int.Parse(Console.ReadLine());
        //     Console.Write("영어 : ");
        //     iEng[i] = int.Parse(Console.ReadLine());
        //     Console.Write("수학 : ");
        //     iMath[i] = int.Parse(Console.ReadLine());

        //     sum[i] = iKor[i] + iEng[i] + iMath[i];
        //     avg[i] = (float)sum[i] / 3;
        // }

        // //출력
        // for(int i=0; i<3; i++)
        // {
        //     Console.WriteLine((i+1)+"번학생");
        //     Console.WriteLine($"국어 : {iKor[i]} 영어 : {iEng[i]} 수학 : {iMath[i]}");
        //     Console.WriteLine($"총점 : {sum[i]} 평균 : {avg[i]}");
        // }

        // //1차원 배열
        // int[] score = new int[3];

        // score[0] = 90;
        // score[1] = 85;
        // score[2] = 88;

        // for (int i=0; i<score.Length; i++)
        // {
        //     Console.WriteLine($"점수 {i + 1}:{score[i]}");
        // }

        // double value = 123.4565789;
        // //소수점 자릿수 설정하는 포맷
        // Console.WriteLine(value.ToString("F2"));
        // Console.WriteLine($"소수점 둘째자리 : {value:F2}");
        // Console.WriteLine(String.Format($"소수점 둘째 자리 : {value:F2}"));
        // //소수점 없애기
        // Console.WriteLine(value.ToString("F0"));

        // double value = 1234121.123124;

        // Console.WriteLine(value.ToString("N2")); //3자리마다 쉼표넣기

        // //2차원 배열 선언
        // int[,] matrix = new int[2, 3]{{1,2,3},{4,5,6}};

        // for(int i=0; i<2; i++)
        // {
        //     for(int j=0; j<3; j++)
        //     {
        //         Console.WriteLine($"{matrix[i,j]}");
        //     }
        //     Console.WriteLine();
        // }

        // int[,] matrix = new int[2,3]{{1,2,3},{4,5,6}};

        // for(int i = 0; i<2; i++)
        // {
        //     for(int j = 0; j<3; j++)
        //     {
        //         Console.WriteLine(matrix[i,j]);
        //     }
        // }

        // //6.가변배열
        // Console.WriteLine("가변 배열");
        // int [][] jaggedArray = new int[3][];

        // jaggedArray[0] = new int[] {1,2};
        // jaggedArray[1] = new int[] {3,4,5};
        // jaggedArray[2] = new int[] {6};

        // for(int i = 0; i<jaggedArray.Length; i++)
        // {
        //     for(int j = 0; j < jaggedArray[i].Length; j++)
        //     {
        //         Console.Write($"{jaggedArray[i][j]}_");
        //     }
        //     Console.WriteLine();
        // }

        Console.WriteLine("var 키워드 사용");
        var num = new[]{1,2,3,4,5};
        Console.WriteLine($"배열 타입: {num.GetType()}");
    }
}
