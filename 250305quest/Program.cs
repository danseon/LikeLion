namespace _250305quest
{
    class Champion //부모 클래스
    {
        public string Name;
        protected int Health;
        public Champion() //생성자
        {
            Name = "Unknown";
            Health = 0;
        }
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}가(이) 기본 공격을 가합니다.");
        }

        public virtual void Heal(Champion target)
        {
            Console.WriteLine("{Name}는 치료 할 수 없습니다.");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}가(이) 이동합니다.");
        }
    }

    class Gankplank : Champion
    {
        public Gankplank()
        {
            Name = "갱플랭크";
            Health = 525;
        }

        public override void Attack()
        {
            Console.WriteLine("갱플랭크가 불의 심판을 사용하여 적을 불태웁니다.");
        }

        public override void Heal(Champion target)
        {
            if (target.Name == "갱플랭크")
                Console.WriteLine("갱플랭크가 귤을 사용해 괴혈병을 치료하고 회복합니다.");
            else
                Console.WriteLine("귤은 갱플랭크만 먹을 수 있습니다.");
        }

    }

    class Galio : Champion
    {
        public Galio()
        {
            Name = "갈리오";
            Health = 600;
        }
        public override void Attack()
        {
            Console.WriteLine("갈리오가 석상의 강타를 사용하여 주변 적들에게 마법피해를 입힙니다.");
        }
        // public void Heal(Champion target)
        // {
        //     //cannot heal
        // }

    }
    class Ambessa : Champion
    {
        public Ambessa()
        {
            Name = "암베사";
            Health = 630;
        }
        // public override void Attack()
        // {

        // }
        // public void Heal(Champion target)
        // {

        // }
        public override void Move()
        {
            Console.WriteLine("암베사가 스킬을 사용 한 직후 돌진합니다.");
        }
    }
    class Nidalee : Champion
    {
        public Nidalee()
        {
            Name = "니달리";
            Health = 610;
        }
        // public override void Attack()
        // {

        // }
        public void Heal(Champion target)
        {
            Console.WriteLine($"니달리가 태고의 생명력을 사용해 {target.Name}를 치료하고 공격속도를 높입니다.");
        }
        public override void Move()
        {
            Console.WriteLine("니달리가 수풀 속에서 더 빠르게 이동합니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Champion> champs = new List<Champion>();

            champs.Add(new Gankplank());
            champs.Add(new Galio());
            champs.Add(new Ambessa());
            champs.Add(new Nidalee());

            //모든 챔피언 명령
            foreach(var champ in champs)
            {
                champ.Move();
                champ.Attack();
                Console.WriteLine();
            }

            Gankplank gank = new Gankplank();
            gank.Heal(champs[1]); //갈리오한테 사용
            gank.Heal(champs[0]); //나한테 사용
            Nidalee nid = new Nidalee();
            nid.Heal(champs[2]); //암베사에게 힐 사용.
        }
    }
}