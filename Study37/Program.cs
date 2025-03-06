using System.Security.Cryptography;

namespace Study37
{
    class Person
    {
        public string Name;
        public int Age = 0;

        public Person() //생성자
        {
            Name = "Unknown";
            Age = 0;
        }
        public Person(string name) //생성자 오버로딩
        {
            Name = name;
        }
        public Person(string name, int age) //생성자 오버로딩
        {
            Name = name;
            Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.Name);

            Person pp = new Person("보름");
            Console.WriteLine(pp.Name);

            Person ppp = new Person("지원",25);
            Console.WriteLine(ppp.Name + ppp.Age);
        }
    }
}