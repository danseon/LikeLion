namespace Study36
{
    class Person
    {
        public string name; //필드 클래스의 데이터를 저장하는 멤버입니다.
        public void SetName(string n) //set 프로퍼티 <-클래스 변수에 직접 접근하지 않고 함수를 통해서 접근
        {
            name = n;
        }
        public string GetName() //Get 프로퍼티 <-클래스 변수에 직접 접근하지 않고 함수를 통해서 접근
        {
            return name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); //객체로 만들기 인스턴스
            p.name = "Alice"; //필드에 값넣기
            Console.WriteLine(p.name);

            Person pp = new Person();
            pp.SetName("보름");
            Console.WriteLine(pp.GetName());
        }
    }
}