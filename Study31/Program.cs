namespace Study31
{
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍!");
        }
        public void WagTail()
        {
            Console.WriteLine("꼬리를 흔든다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Dog(); //업캐스팅 (부모로 자식 객체를 참조)
            myAnimal.Speak(); //부모 -> 자식 / 오버라이딩된 자식클래스의 메서드가 실행된다. (멍멍!)

            Dog d = (Dog)myAnimal; //다운캐스팅 (업캐스팅한 객체를 다시 자식 객체로 캐스팅)
            d.WagTail(); // 자식 클래스의 메서드로 바로 접근 가능

            Animal myAni = new Animal();
            myAni.Speak();
        }
    }
}