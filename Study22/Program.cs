﻿using System;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Study22
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("프로그램 종료");

            // string path = Environment.GetEnvironmentVariable("PATH");
            // Console.WriteLine($"PATH: {path}");
            // Random rnd = new Random();
            // int a = rnd.Next(0,101);
            // Console.WriteLine(a);

            // Environment.Exit(0);

            // //프로그램 실행 시간 구하기
            // Stopwatch stopwatch = Stopwatch.StartNew();
            // //실행코드
            // for(int i = 0; i < 100; i++)
            // {
            //     Thread.Sleep(1);
            // }
            // stopwatch.Stop();

            // Console.WriteLine("포문 시간 : " + stopwatch.ElapsedMilliseconds);

            // string input = "Hello, my phone number is 010-1234-5678.";
            // string pattern = @"\d{3}-\d{4}-\d{4}";
            // bool isMatch = Regex.IsMatch(input, pattern);
            // Console.WriteLine($"전화번호가 있나? {isMatch}");

            //클래스 시그니차 기본구성
            //c#에서 클래스 시그니처는 클래스의 선언부를 의미한다.

            //[접근 지정자][수정자] class 클래스이름 : 부모클래스   ,  인터페이스
            //Public     abstract             : BaseClass ,  IComparable
            //private    sealed
            //protected  static
            //           patial
        }
    }
    public class Player //기본 클래스
    {
        public string Name {get; set;}
        public int Score {get; set;}
    }
    //상속하는 클래스
    public class warrior : Player
    {
        public int Strength {get; set;}
    }
    //인터페이스 구현 클래스
    // public class Enemy : IAttackable, IMovele
    // {
    //     public void Attack(){}
    //     public void Move(){}
    // }
    //추상 클래스 (abstract)
    public abstract class Animal
    {
        public abstract void MakeSound();
    }
}