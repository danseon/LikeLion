using System;

namespace TEXTRPG_practice
{
    public class Field
    {
        Player m_Player = null;
        Monster m_Monster = null; //메인게임에서 만들어진 객체들 인자 가져오기

        public void SetPlayer(ref Player pPlayer) { m_Player = pPlayer;}

        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;
            while (true)
            {
                Console.Clear();

                m_Player.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if(iInput == 4)break; //4는 종료
                if(iInput <=3)
                {
                    //1 초보 2 중급 3 고급
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO(); //몬스터용 INFO 인스턴스 만들기

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster); //INFO 인자 집어넣어서 Monster객체 능력치 세팅하기
        }
        public void CreateMonster(int input)
        {
            switch(input)
            {
                case 1:
                    Create("초보몹",30,3,out m_Monster);
                    break;
                case 2:
                    Create("중수몹",60,6,out m_Monster);
                    break;
                case 3:
                    Create("고급몹",90,9,out m_Monster);
                    break;
            }
        }
        public void Fight() //전투
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_Player.Render();
                m_Monster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if(iInput == 1) //공격
                {
                    m_Player.SetDamage(m_Monster.GetMonster().iAttack);
                    m_Monster.SetDamage(m_Player.GetInfo().iAttack);

                    if (m_Player.GetInfo().iHp <= 0)
                    {
                        m_Player.SetHp(100); // 체력 100으로 부활
                        break;
                    }
                }

                if(iInput == 2 || m_Monster.GetMonster().iHp <=0)
                {
                    m_Monster = null;
                    break;
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("==========");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field(){}
        ~Field(){}
    }
}