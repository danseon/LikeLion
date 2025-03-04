﻿using System.Collections;

namespace Study24
{

    class Program
    {
        static void Main(string[] args)
        {
            // //배열과 컬렉션
            // int[] numbers = {1,2,3,4,5}; //int 배열

            // foreach (var num in numbers)
            // {
            //     Console.WriteLine(num);
            // }

            //리스트 : 배열과 비슷하지만 동적으로 크기가 변하는 가변 길이 자료형
            // List<string> names = new List<string> {"Alice","Bob","Charlie"};

            // names.Add("Dave");
            // names.Remove("Bob");

            // foreach(var name in names)
            // {
            //     Console.WriteLine(name);
            // }

            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(list[1]);
            //list.Insert(1, 100);
            //Console.WriteLine(list[1]);

            //Console.WriteLine(list[0]);

            // list.Insert(1, 100);
            // Console.WriteLine(list.Count);

            // list[2] = 200;

            // foreach (int i in list)
            // {
            //     Console.WriteLine(i);
            // }

            //stack

            // Stack<int>stack = new Stack<int>();

            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);

            // while (stack.Count > 0)
            // {
            //     Console.WriteLine(stack.Pop());
            // }

            // Queue<string>queue = new Queue<string>();

            // queue.Enqueue("q");
            // queue.Enqueue("w");
            // queue.Enqueue("e");
            // queue.Enqueue("r");
            // queue.Enqueue("점멸");
            // queue.Enqueue("평타");


            // while (queue.Count > 0)
            // {
            //     Console.WriteLine(queue.Dequeue());
            // }

            //queue 선입선출 first in first out
            // Queue<string>queue = new Queue<string>();

            // queue.Enqueue("→");
            // queue.Enqueue("↓");
            // queue.Enqueue("↘");
            // queue.Enqueue("→");
            // queue.Enqueue("풍신권");



            // while (queue.Count > 0)
            // {
            //     Console.WriteLine(queue.Dequeue());
            // }

            // Console.WriteLine(queue.Count);

            // //ArrayList 생성
            // //크기가 동적으로 조정되는 배열, 다양한 형식의 데이터를 저장할수있다.
            // ArrayList<List>arrayList = new ArrayList();

            // //요소추가
            // arrayList.Add(1);  //정수
            // arrayList.Add("Hello");  //문자열
            // arrayList.Add(3.14);    //실수


            // //요소 접근
            // Console.WriteLine("ArrayList 요소: ");
            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }

            // //요소 제거
            // arrayList.Remove(1);

            // Console.WriteLine("\n ArrayList요소 제거 후: ");

            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }

            //HashTable 클래스
            //키-값 쌍을 저장하는 컬렉션이다.
            //키를 이용해 값을 빠르게 검색

            // Hashtable hashtable = new Hashtable();

            // //키-값 쌍 추가
            // hashtable["Alice"] = 25;
            // hashtable["Bob"] = 30;
            // hashtable["포션"] = 20;

            // Console.WriteLine("hashtable 요소 : ");

            // foreach(DictionaryEntry entry in hashtable)
            // {
            //     Console.WriteLine($"key : {entry.Key}, Value : {entry.Value}");
            // }

            // //특정 키의 값 가져오기
            // Console.WriteLine($"\n Alice의 나이 : {hashtable["Alice"]}");

            // //요소제거
            // hashtable.Remove("Bob");

            // Console.WriteLine("Hashtable 요소:");

            // foreach (DictionaryEntry entry in hashtable)
            // {
            //     Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            // }

            //제네릭 사용하기(Generic)
            //<T> 제네릭 클래스를 사용하면 특정 타입에 종속되지 않는 범용 클래스를 만들 수 있습니다.
        }
    }
}