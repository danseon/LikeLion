namespace Study21
{

    // class Person
    // {
    //     private string name; //내부 변수
    //     // //값 설정하기 (Setter)
    //     // public void SetName(string name)
    //     // {
    //     //     this.name = name;
    //     // }
    //     // //값 가져오기 (Getter)
    //     // public string GetName()
    //     // {
    //     //     return name;
    //     // }

    //     public string Name //프로퍼티
    //     {
    //         get {return name;} //getter
    //         set {name = value;} //setter 위와 동일한 코드임.
    //     }
    // }

    //프로퍼티 자동 구현

    // class Person
    // {
    //     private int count = 100;
    //     public string Name {get;set;} // 위 2개가 최종적으로 형태로 축약 가능.

    //     public int Count
    //     {
    //         get {return count;}
    //     }
    //     public float Balance { get; private set; } //외부 변경 불가

    //     public void AddBal()
    //     {
    //         Balance += 100;
    //     }
    // }


    //마린클래스
    //프로퍼티 이용해서 이름과 미네랄을 만드시오. 이름 마린 미네랄 50
    class Marin
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set;} = 50;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // //c#에서 get/set 방식의 함수와 프로퍼티 비교
            // Person p = new Person();

            // // p.name = "이름"; //public일땐 접근 가능, private일땐 불가능
            // p.Name = "보름"; //public SetName함수를 선언해놓고, private 변수에 접근 가능하다.
            // p.AddBal();
            // //public GetName함수로 private 변수 불러온다.
            // Console.WriteLine("이름 : " + p.Name+" Count : "+ p.Count +" Balance "+p.Balance); 

            Marin m = new Marin();
            Console.WriteLine($"이름 : {m.Name} 미네랄 : {m.Mineral}");
        }
    }
}