﻿using System.Collections;
using System.Collections.Generic;

namespace Study25
{
    class Cup<T>
    {
        public T Content { get; set; }
    }

    //커스텀 컬렉션
    class SimpleCollection : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Cup<string> cupOfString = new Cup<string> { Content = "Coffee" };
            // Cup<int> cupOfInt = new Cup<int> { Content = 42 };

            // Console.WriteLine($"CupOfString : {cupOfString.Content}");
            // Console.WriteLine($"CupOfInt : {cupOfInt.Content}");

            // Stack<int> stack = new Stack<int>();

            // stack.Push(10);
            // stack.Push(20);
            // stack.Push(30);

            // while(stack.Count > 0)
            // {
            //     Console.WriteLine(stack.Pop());
            // }

            // List<string> names = new List<string> {"Alice", "Bob", "Charlie"};
            // names.Add("Dave");

            // foreach(var name in names)
            // {
            //     Console.WriteLine(name);
            // }

            // //IEnumerator
            // //C#컬렉션 순회 반복 할 수 있는 인터페이스
            // //foreach 없이도 컬렉션 순회 가능
            // //LINQ나 커스텀 컬렉션을 만들 때 유용함.
            // ArrayList list = new ArrayList { "Apple", "Banana", "Cherry"};
            // IEnumerator enumrator = list.GetEnumerator(); //열거자 가져오기

            // while(enumrator.MoveNext()) //다음 요소가 있는지 확인
            // {
            //     Console.WriteLine(enumrator.Current); //현재 요소 출력
            // }

            // //커스텀 컬렉션
            // var collection = new SimpleCollection();

            // foreach (var i in collection)
            // {
            //     Console.WriteLine(i);
            // }

            //딕셔너리
            // Dictionary<string, int> ages = new Dictionary<string, int>();

            // ages["금도끼"] = 10;
            // ages["은도끼"] = 5;
            // ages["돌도끼"] = 1;

            // foreach (var pair in ages)
            // {
            //     Console.WriteLine($"{pair.Key} : {pair.Value}");
            // }

            //Null값
            //참조형식 null을 가질 수 있으며, 값 형식은 기본적으로 Null을 가질 수 없습니다.

            // String str = null;

            // if(str == null)
            // {
            //     Console.WriteLine("str is null");
            // }

            //int에도 null값을 넣을 수 있다.
            // int? nullableInt = null;
            // Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "no value");
            // nullableInt = 10;
            // Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "no value");

            //null 값을 달는 연산자 소개하기 ??,? 연산자
            //?? 연산자를 사용해 null인 경우 대체값을 제공하고, ?.은 null 안전 접근을 합니다.
            // string str = null;
            // Console.WriteLine(str ?? "DefaultValue");//str null이면 "Default Value
            // str = "Hello";
            // Console.WriteLine(str?.Length); //str이 null이 아니므로 길이 출력

            //LINQ는 확장메서드 형태로 제공된다.
            //LINQ(Language Integrated Query)를 사용해 컬렉션을 쿼리 할 수 있습니다.
            int[] numbers = { 1, 2, 3, 4, 5 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}