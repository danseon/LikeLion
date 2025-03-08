using System;

namespace TEXTRPG_practice
{
    //게임 시작 후에 플레이어 캐릭터 고르고, 그 필드의 값들을 관리하는 클래스
    public class Player
    {
        public INFO m_Info;

        //데미지 함수
        public void SetDamage(int iAttack){m_Info.iHp -= iAttack;} //iat만큼 ihp 빼기
        public INFO GetInfo() {return m_Info;} //info를 반환하기
        public void SetHp(int iHp) { m_Info.iHp = iHp;} // hp를 다시 설정해주는 함수

        //직업선택
        public void SelectJob()
        {
            m_Info = new INFO(); // 플레이어 정보를 담을 새로운 INFO객체 선언

            Console.WriteLine("직업을 선택하세요 (1.기사 2.마법사 3.도둑) : ");
            int iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_Info.strName = "기사 박씨"; //기사일 경우 INFO 객체 셋팅값
                    m_Info.iHp = 200;
                    m_Info.iAttack = 30;
                    break;
                case 2:
                    m_Info.strName= "마법사 최씨";
                    m_Info.iHp = 100;
                    m_Info.iAttack = 50;
                    break;
                case 3:
                    m_Info.strName="도둑 정씨";
                    m_Info.iHp = 80;
                    m_Info.iAttack = 70;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("=================");
            Console.WriteLine("직업과 이름 : " + m_Info.strName);
            Console.WriteLine($"체력 : {m_Info.iHp} 공격력 : {m_Info.iAttack}");
        }

        public Player(){}
        ~Player(){}
    }
}