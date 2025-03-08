using System;

namespace TEXTRPG_TEST
{

    public class MainGame
    {
        public Player m_Player = null;
        public Field m_Field = null;
        public void Initialize()
        {
            m_Player = new Player();
            m_Player.SelectJob();
        }
        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_Player.Render();
                Console.WriteLine("1.사냥터 2.종료");
                iInput = int.Parse(Console.ReadLine());

                if (iInput == 1) //필드 구현
                {
                    if (m_Field == null)
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
    }
}