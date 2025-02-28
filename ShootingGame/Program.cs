using System;

namespace ShootingGame
{
    //미사일 클래스
    public class BULLET
    {
        public int x;
        public int y;
        public bool fire;
    }
    //플레이어 클래스
    public class Player
    {
         [DllImport("msvcrt.dll")]
         static extern int _getch();  //c언어 함수 가져옴

        public int playerX; //플레이어 x좌표
        public int playerY; //플레이어 좌표
        public BULLET[] playerBullet = new BULLET[20]; //미사일 배열

        public Player() //생성자
        {
            playerX = 0;
            playerY = 12;
            for(int i = 0; i<20; i++) //총알 초기화
            {
                playerBullet[i] = new BULLET();
                playerBullet[i].x = 0;
                playerBullet[i].y = 0;
                playerBullet[i].fire = false;
            }
        }

        public void GameMain()
        {
            //키를 입력하는 부분
            KeyControl();
            PlayerDraw();
        }
        
        public void KeyControl()
        {
            int pressKey; // 정수형 변수선언 키값

            if(Console.KeyAvailable) // 키가 눌렸을때 true
            {
                pressKey = _getch(); // getch = 아스키값 왼쪽 오른쪽 입력받는 c함수

                switch(pressKey)
                {
                    case 72: //위쪽 방향 아스키코드
                    {
                        playerY--;
                        if(playerY < 1)
                           playerY = 1;
                        break;
                    }
                    case 75: //왼쪽화살표
                    {
                        playerX--;
                        if (playerX < 1)
                            playerX = 0;
                        break;
                    }
                    case 77: //오른쪽 화살표
                    {
                        playerX++;
                        if (playerX > 75)
                            playerX = 0;
                        break;
                    }
                    case 80: //아래
                    {
                        playerY++;
                        if(playerY > 23)
                           playerY = 23;
                        break;
                    }
                    case 32: //스페이스바
                    {
                    //총알 발사
                      for(int i = 0; i<20; i++)
                      {
                        //미사일이 False 발사가능
                        if (playerBullet[i].fire == false)
                        {
                            playerBullet[i].fire = true;
                            //플레이어 앞에서 미사일 쏘기 + 5
                            playerBullet[i].x = playerX + 5;
                            playerBullet[i].y = playerY;
                            //한발씩 쏘겠다
                            break;
                        }
                      }                      
                    }
                    break;
                }
            }
        }
        public void BulletDraw()
        {
            string bullet = "->"; //미사일 모습

            //20개
            for(int i=0; i<20; i++)
            {
                //미사일이 살아있는 상태
                if (playerBullet[i].fire == true)
                {
                    //좌표설정 -> 중간위치를 보정하기 위해서 x-1
                    //  -> 이 모양에서 -와> 사이를 좌표값으로 계산
                    Console.SetCursorPosition(playerBullet[i].x, playerBullet[i].y);
                    //총알 출력
                    Console.Write(bullet);

                    playerBullet[i].x++; //미사일을 오른쪽으로 날리기

                    if (playerBullet[i].x >79) //미사일이 밖으로 나가면
                    {
                        playerBullet[i].fire = false;
                    }
                }
            }
        }
        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기

            for(int i=0; i<player.Length; i++)
            {
                //콘솔좌표 설정 플레이어x 플레이어Y
                Console.SetCursorPosition(playerX, playerY + i);
                //문자열배열 출력
                Console.WriteLine(player[i]);
            }
        }
        //충돌처리
        public void ClashEnemyAndBullet(Enemy enemy)
        {

        }
    }

    public class Enemy //적 클래스
    {
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            //적 좌표 초기화
            enemyX = 77;
            enemyY = 12;
        }
        public void EnemyDraw()
        {

        }
        public void EnemyMove()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Console.CursorVisible = false; //커서 끄기
           Console.SetWindowSize(80,25); //콘솔창 크기설정
           Console.SetBufferSize(80, 25); //버퍼 설정

           //플레이어 생성
           Player player = new Player();
           Enemy enemy = new Enemy(); //적생성

           //유니티처럼 속도 프레임속도
           int dwTime = Environment.TickCount; // 1/1000초가 흐른다.

           while(true) //무한반복
           {
            //0.05초 지연
            if(dwTime + 50 < Environment.TickCount)
            {
                //현재시간 세팅
                dwTime = Environment.TickCount;
                Console.Clear();

                //플레이어
                player.GameMain();
                //총알
                player.BulletDraw();

                enemy.EnemyMove(); //적이동
                enemy.EnemyDraw(); //적그리기

                //충돌처리
                player.ClashEnemyAndBullet(enemy);
            }
           }
        }
    }
}
