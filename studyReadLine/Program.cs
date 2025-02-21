using System;

namespace studyReadLine
{

    class Program
    {
        static void Main(string[] arg)
        {
            // //사용자 입력을 문자열로 받기
            // Console.Write("이름을 입력하세요: ");
            // string userName = Console.ReadLine();

            // Console.WriteLine($"안녕하세요, {userName}님!");

            //문자열을 정수로 변환
            // Console.Write("나이를 입력하세요: ");
            // string input = Console.ReadLine();
            // int age = int.Parse(input);

            // Console.WriteLine($"내년에는 {age+1}살이 되겠군요!");
            // Console.WriteLine("내년에는 " + (age+1) + "살이 되겠군요!");
            // Console.WriteLine("내년에는 {0}살이 되겠군요!", age+1);

            //스샷내용 입력받아서 출력
            //루인 스킬 피해 : 4.5<-입력받기

            float Skill_Damage = 0.0f;
            float Card_Gage = 0.0f;
            float Awake_Damage = 0.0f;
            int Max_Mana = 0;
            int Com_Mana = 0;
            int ComNon_Mana = 0;
            float speed = 0.0f;
            float riding_speed = 0.0f;
            float con_speed = 0.0f;
            float cooldown = 0.0f;

            Console.WriteLine("활동");

            Console.Write("스킬 피해량을 입력하세요 : ");
            Skill_Damage = float.Parse(Console.ReadLine());

            Console.Write("카드 게이지를 입력하세요 : ");
            Card_Gage = float.Parse(Console.ReadLine());

            Console.Write("각성기 피해량을 입력하세요 : ");
            Awake_Damage = float.Parse(Console.ReadLine());

            Console.Write("촤대 마나를 입력하세요 : ");
            Max_Mana = int.Parse(Console.ReadLine());

            Console.Write("전투중 마나회복량을 입력하세요 : ");
            Com_Mana = int.Parse(Console.ReadLine());

            Console.Write("비전투중 마나회복량을 입력하세요 : ");
            ComNon_Mana = int.Parse(Console.ReadLine());

            Console.Write("이동 속도를 입력하세요 : ");
            speed = float.Parse(Console.ReadLine());
            
            Console.Write("탈 것 속도를 입력하세요 : ");
            riding_speed = float.Parse(Console.ReadLine());

            Console.Write("운반 속도를 입력하세요 : ");
            con_speed = float.Parse(Console.ReadLine());

            Console.Write("스킬 재사용 대기시간 감소를 입력하세요 : ");
            cooldown = float.Parse(Console.ReadLine());

            Console.WriteLine($"루인 스킬 피해 감소 :   {Skill_Damage}%");
            Console.WriteLine($"카드 게이지 획득량 :   {Card_Gage}%");
            Console.WriteLine($"각성기 피해 :   {Awake_Damage}%");
            Console.WriteLine($"최대 마나 :   {Max_Mana}");
            Console.WriteLine($"전투 중 마나 회복량 :   {Com_Mana}");
            Console.WriteLine($"비전투 중 마나 회복량 :   {ComNon_Mana}");
            Console.WriteLine($"이동 속도 :   {speed}%");
            Console.WriteLine($"탈 것 속도 :   {riding_speed}%");
            Console.WriteLine($"운반 속도 :   {con_speed}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소 :   {cooldown}%");
            
        }
    }
}