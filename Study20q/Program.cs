using System;

namespace Study20q
{
    //마린 클래스를 만드세요
    //이름,미네랄 = 50
    //기본생성자 , 인자있는생성자
    //this 키워드를 이용해보자
    //this는 클래스 내부의 자기 변수를 가르킨다.
    class Marin
    {
        public string Name;
        public int Mineral;
        public Marin() //기본 생성자
        {
            Name = "마린";
            Mineral = 50;
        }
        public Marin(string _name, int _mineral) //매개 변수 있는 생성자
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    class Scv
    
    {
        public string Name;
        public int Mineral;
        public Scv()
        {
            Name = "SCV";
            Mineral = 50;
        }
        public Scv(string _name, int _mineral)
        {
            Name = _name;
            Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    class Barracks
    {
        public string Name;
        public int Mineral;

        public Barracks() //기본생성자
        {
            this.Name = "병영";
            this.Mineral = 150;
        }
        public Barracks(string _name, int _mineral) //매개변수 생성자
        {
            this.Name = _name;
            this.Mineral = _mineral;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"이름 : {Name}, 미네랄 : {Mineral}");
        }
    }
    //미네랄 클래스를 만드시오
    //Mineral 1500 기본으로 주네요
    //7개가 시작부터 있습니다.
    //클래스화 해봅시다.
    class MineralField
    {
        //public string Name;
        public int Amount;

        public MineralField() // 기본 생성자
        {
            //Name = "미네랄 덩어리";
            Amount = 1500;
        }
        public MineralField(/*string Name, */int Amount)
        {
            //this.Name = Name;
            this.Amount = Amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"자원량 : {Amount}");
        }
    }
    //game클래스를 만들어보자
    class Game
    {
        public static int Mineral; //static 키워드는 객체를 생성 하는 것이 아니라
        public static int Gas;     //클래스 내부의 변수에 직접 접근해서 바꾸도록 한다.
        public static int charCount; //그래서 프로그램에서 공통적으로 쓰이는 변수에 붙인다.

        public static void ShowInfo() //static이기 때문에 객체를 생성 할 필요 없이 바로 접근.
        {
            Console.WriteLine($"미네랄 {Mineral} 가스{Gas} 인구수{charCount}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //기본생성자로 만든 유닛
            Marin marin = new Marin();
            Scv scv = new Scv();
            Barracks barracks = new Barracks();
            marin.ShowInfo();
            scv.ShowInfo();
            barracks.ShowInfo();
        
            //매개변수 생성자로 만든 유닛
            Marin kmarin = new Marin("한국마린",1000);
            Scv kscv = new Scv("한국scv",1000);
            kmarin.ShowInfo();
            kscv.ShowInfo();
            
            
            MineralField[] mineral = new MineralField[7]; //클래스의 배열 (7개 객체 선언)
            for (int i = 0; i < mineral.Length; i++)
            {
                //7개의 클래스 객체에 생성자 불러옴 (New 객체화)
                mineral[i] = new MineralField();
                mineral[i].ShowInfo();
            }

            Game.Mineral = 50;
            Game.Gas = 0;
            Game.charCount = 4;
            Game.ShowInfo();

        }
    }
}