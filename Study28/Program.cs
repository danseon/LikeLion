namespace Study28
{
    class Player
    {
        public string name;
        
        public void Render()
        {
            Console.WriteLine("플레이어 : " + name);
        }
    }

    class wizard : Player
    {
        public string job;

        public void Render2()
        {
            Console.WriteLine("직업은 " + job + " 입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(); //객체

            p.name = "홍길동";
            p.Render();
            // p.job은 자식클래스의 변수라서 사용못한다.

            wizard w = new wizard();

            w.name = "30살의 박춘식";
            w.job = "마법사";
            w.Render();
            w.Render2();

        }
    }
}