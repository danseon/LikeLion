using System;

namespace TEXTRPG_TEST
{
    public class Player
    {
        public INFO m_info;
        public void SetDamage(int iAttack) { m_info.iHp -= iAttack; }
        public INFO GetInfo() { return m_info; }
        public void SetHp(int iHp) { m_info.iHp = iHp; }

        public void SelectJob()
        {
            m_info = new INFO();
            Console.WriteLine("===============");
            Console.WriteLine("직업을 선택하세요.");
            Console.Write("1.기사 2.마법사 3.도적 : ");
            int iInput = int.Parse(Console.ReadLine());

            if (iInput == 1)
            {
                m_info.strName = "기사";
                m_info.iHp = 100;
                m_info.iAttack = 10;
            }
            if (iInput == 2)
            {
                m_info.strName = "마법사";
                m_info.iHp = 80;
                m_info.iAttack = 20;
            }
            if (iInput == 3)
            {
                m_info.strName = "도적";
                m_info.iHp = 90;
                m_info.iAttack = 15;
            }
        }
        public void Render()
        {
            Console.WriteLine("=============================================");
            Console.WriteLine($"직업 이름 : {m_info.strName}");
            Console.WriteLine($"체력 : {m_info.iHp} 공격력 : {m_info.iAttack}");
        }
    }
}