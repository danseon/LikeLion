using System;

namespace BrickGame
{

    public class GameManager
    {
        Ball m_Ball = null;
        Bar m_Bar = null;
        Block m_Block = new Block;
        
        public void Initialize()
        {
            if(m_Ball == null)
            {
                m_Ball = new Ball();
                m_Ball.Initialize();
            }

            //바
            if(m_Bar == null)
            {
                m_Bar = new Bar();
                m_Bar.Initialize();
            }

            //볼에서 바와 벽돌을 사용해야 할 것 같다.
            m_Ball.SetBar(m_Bar);
        }
        public void Progress()
        {
            m_Ball.Progress();
            m_Bar.Progress(ref m_Ball);
        }
        public void Render()
        {
            Console.Clear();
            m_Ball.Render();
            m_Bar.Render();
            m_Block.Render();
        }
        public void Release()
        {
            m_Ball.Release();
        }
    }
}