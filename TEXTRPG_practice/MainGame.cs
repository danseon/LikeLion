using System;

namespace TEXTRPG_practice
{

    public class MainGame
    {
        public Player m_Player = null;
        public Field m_Field = null;

        //플레이어 초기화 함수
        public void Initialize()
        {
            //플레이어 생성 및 직업 선택
            m_Player = new Player();
            m_Player.SelectJob();
        }

        public void Progress()
        {
            int iInput = 0;

            while(true)
            {
                Console.Clear();
                m_Player.Render(); //플레이어 출력
                Console.WriteLine("1. 사냥터 2. 종료");
                iInput = int.Parse(Console.ReadLine());
                if (iInput == 1)
                {
                    if(m_Field == null)
                    {
                        m_Field = new Field();
                        m_Field.SetPlayer(ref m_Player);
                    }
                    m_Field.Progress();
                }
                if (iInput == 2)
                    break;
            }
        }

        public MainGame(){}
        ~MainGame(){}
    }
}