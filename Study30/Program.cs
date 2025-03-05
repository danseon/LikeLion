namespace Study30
{   //업캐스팅(Upcasting)
    //자식 클래스->부모클래스로 변환하는것
    //암시적 변환이 가능(컴파일러가 자동변환)
    //안전: 데이터 손실 없이 변환가능

    //다운캐스팅
    //명시적 변환이 필요(타입)
    //불완전함 -> 실행중 invalidcastException 발생가능
    //as is 키워드로 안전하게 변환가능
    class Animal
    {
        public void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("멍멍!");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            // //업캐스팅
            // Dog myDog = new Dog(); //자식 클래스 객체 생성
            // Animal myAnimal = myDog; //업캐스팅

            // myAnimal.Speak(); //부모 클래스 메서드 사용가능
            // //myAnimal.Bark()는 사용 불가. 업캐스팅 했기 때문에 자식 클래스 메서드는 접근 불가

            Animal myAnimal = new Dog(); //업캐스팅
            //Dog myDog = (Dog)myAnimal; //다운캐스팅 (명시적 변환)
            Dog myDog = myAnimal as Dog; //다운캐스팅 방식2

            if (myDog != null)
            {
                myDog.Bark();
            }
            else
            {
                Console.WriteLine("변환 실패!");
            }


            myDog.Bark();

            //Animal myAnimal12 = new Animal();<-
            // Dog myDog = (Dog)myAnimal12;    <- 안된다.

            if (myAnimal is Dog myDog1)
            {
                myDog1.Bark();
            }
            else
            {
                Console.WriteLine("변환 할 수 없습니다.");
            }
        }
    }
}