using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BrickGame
{

    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch();

        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x,y);
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(80,25);
            Console.SetBufferSize(80,25);

            GameManager gm = new GameManager();
            gm.Initialize();

            int curr = Environment.TickCount;

            while(true)
            {
                if(curr+50 < Environment.TickCount) //50ms마다 프로그레스 + 렌더 즉 20프레임
                {
                    curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }
        }
    }
}