using System;

namespace TEXTRPG_practice
{

    public class Monster
    {
        public INFO m_Monster;

        public void SetDamage(int iAttack) {m_Monster.iHp -= iAttack;}
        public void SetMonster (INFO monster) {m_Monster = monster;} //몬스터 객체 받아오기
        public INFO GetMonster() {return m_Monster;} //몬스터 객체 반환하기

        public void Render()
        {
            Console.WriteLine("============");
            Console.WriteLine($"몬스터 이름 : {m_Monster.strName}");
            Console.WriteLine($"체력 : {m_Monster.iHp} 공격력 : {m_Monster.iAttack}");
        }

        public Monster(){}
        ~Monster(){}
    }
}