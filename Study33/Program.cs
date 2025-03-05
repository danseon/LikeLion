namespace Study33
{
    class Player
    {
        protected string Name; //부모자식 상속관계에서만 쓰고싶을때
        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("부모 생성자 입니다.");
        }

        public void Show()
        {
            Console.WriteLine(Name);
        }
    }

    class Wizzard : Player
    {
        public Wizzard()
        {
            Name = "마법사";
            Console.WriteLine($"자식 생성자 입니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Player p = new Player();
            //p.Show(); //생성자 호출 -> show 메서드 호출
            Wizzard w = new Wizzard(); //생성자
            w.Show();
        }
    }
}