using System;
using System.Security.Cryptography.X509Certificates;

namespace TEXTRPG_TEST
{
    public class Field
    {
        Player m_Player = null;
        Monster m_Monster = null;

        public void SetPlayer(ref Player player) { m_Player = player; }

        public void Progress()
        {
            //사냥터 입장
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_Player.Render();
                DrawMap();
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4) //4면 종료
                    break;

                if (iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;

            pMonster.SetMonster(tMonster);
        }
        public void CreateMonster(int iInput)
        {
            switch (iInput)
            {
                case 1:
                    Create("초보몹", 30, 3, out m_Monster);
                    break;
                case 2:
                    Create("중급몹", 60, 6, out m_Monster);
                    break;
                case 3:
                    Create("고급몹", 90, 9, out m_Monster);
                    break;
            }
        }
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_Player.Render();
                m_Monster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    //플레이어 데미지 주기 -> 몬스터 공격력 넣어서 데미지
                    m_Player.SetDamage(m_Monster.GetMonster().iAttack);
                    //몬스터 데미지 주기 -> 플레이어 공격력 넣기
                    m_Monster.SetDamage(m_Player.GetInfo().iAttack);

                    if (m_Player.GetInfo().iHp <= 0)
                    {
                        m_Player.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || m_Monster.GetMonster().iHp <= 0)
                {
                    m_Monster = null;
                    break;
                }
            }
        }
        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중급맵");
            Console.WriteLine("3. 고급맵");
            Console.WriteLine("4. 돌아가기");
            Console.WriteLine("=============");
            Console.Write("맵을 선택하세요. : ");
        }
    }
}