using System;
using System.Data;

namespace Study20
{
    class Person
    {
        public string Name;
        public int Age;

        //기본생성자
        //클래스가 객체로 생성될 때 자동으로 실행되는 특별한 메서드
        //클래스와 같은 이름이며, 반환형이 없다 (void도 사용하지않음)
        //객체를 만들 때 필요한 초기값을 설정할 때 사용을 많이 한다.
        //선언을 안해도 내부적으로 동작함.
        public Person(string name, int age) //생성자는 클래스랑 이름이 같다.
        {
            // Name = "이름 없음";
            // Age = 0;
            // Console.WriteLine("생성자가 실행되었습니다.");
            Name = name;
            Age = age;
            Console.WriteLine("매개변수가 있는 생성자가 실행되었습니다.");
        }
        public void ShowInfo()
        {
            Console.WriteLine("이름 : "+Name);
            Console.WriteLine("나이 : "+Age);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //클래스
            //
            Person p1 = new Person("보름",10); // 객체 생성 instance (이 때 자동으로 생성자가 실행된다.)
            p1.ShowInfo();
            Person p2 = new Person("영희",20);
            p2.ShowInfo();
        }
    }
}