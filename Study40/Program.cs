namespace Study40_41
{
    //부모 클래스의 생성자 호출
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine("부모생성자" + message); //순서2
        }
    }
    class Child : Parent
    {
        public Child():base("하하하하성공") //자식 생성자가 부모 생성자 호출 순서1
        {
            Console.WriteLine("자식 생성자 호출"); //순서3
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child= new Child();

        }
    }
}