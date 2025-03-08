using System;

namespace BrickGame
{
    public class Block
    {
        BLOCKDATA[] m_block = new BLOCKDATA[20];
        Random rnd = new Random();
        public Block()
        {
            for (int i = 0; i < m_block.Length; i++)
            {
                m_block[i].bX = rnd.Next(20,61);
                m_block[i].bY = rnd.Next(15,25);
            }
        }
        public void Render()
        {   
            for (int i = 0; i < m_block.Length ; i++ )
            {
            Program.gotoxy(m_block[i].bX, m_block[i].bY);
            Console.Write("◼︎");
            }
        }
    }
}