using System;

namespace TEXTRPG
{

    public class Field
    {
        Player m_pPlayer = null;
        //몬스터
        Monster m_pMonster = null;

        //플레이어 maingame에서 생성한거 가지고옴
        //플레이어가 필드에서 전투하면 데미지를 입고 hp가 깎임
        //ref 사용
        public void SetPlayer(ref Player pPlayer) { m_pPlayer = pPlayer; }

        public void Progress()
        {
            //사냥터로 들어왔다.
            int iInput = 0;
            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                if (iInput <= 3)
                {
                    //몬스터를 만들고
                    //1번일때 초보몬스터
                    //2번일때 중급몬스터
                    //3번일때 고급몬스터     
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }
        //생성을 도와주는 함수
        //공장처럼 찍어낸다.
        //팩토리 메서드 패턴
        public void Create(string _strName, int _iHp, int _iAttack, out Monster pMonster)
        {
            pMonster = new Monster();
            INFO tMonster = new INFO(); //몬스터 데이터 메모리용 객체 생성

            tMonster.strName = _strName; //
            tMonster.iHp = _iHp; //체력
            tMonster.iAttack = _iAttack; //공격력

            pMonster.SetMonster(tMonster); //생성된 INFO 클래스타입 인자로 데이터 세팅
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    //공장처럼 찍어내준다.
                    //디자인패턴 팩토리 메서드 패턴
                    Create("초보몹", 30, 3, out m_pMonster);
                    break;
                case 2:
                    //공장처럼 찍어내준다.
                    //디자인패턴 팩토리 메서드 패턴
                    Create("중수몹", 60, 6, out m_pMonster);
                    break;
                case 3:
                    //공장처럼 찍어내준다.
                    //디자인패턴 팩토리 메서드 패턴
                    Create("초보몹", 90, 9, out m_pMonster);
                    break;
            }
        }
        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_pMonster.Render();

                Console.WriteLine("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1)
                {
                    //플레이어 데미지 주기 -> 몬스터 공격력 넣어서 데미지
                    m_pPlayer.SetDamage(m_pMonster.GetMonster().iAttack);
                    //몬스터 데미지 주기 -> 플레이어 공격력 넣기
                    m_pMonster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.SetHp(100);
                        break;
                    }
                }

                if (iInput == 2 || m_pMonster.GetMonster().iHp <= 0)
                {
                    m_pMonster = null;
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
            Console.WriteLine("============");
            Console.WriteLine("맵을 선택하세요 : ");
        }

        public Field(){}
        ~Field(){}
    }
}