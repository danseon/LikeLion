using System;

namespace _250225quest;

class Program
{
    static void Main(string[] args)
    {
        
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			Random rand = new Random();

            int gold = 1000;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine("🍄 버섯 키우기 🍄");
            Thread.Sleep(1000);

            while(isAlive)
            {
                Console.Clear();
                Console.WriteLine($"현재 상태 : 크기 {health} | 골드 {gold} | 맛 {power}");
                Console.WriteLine("\n1. 버섯 캐기🍄 ");
                Console.WriteLine("2. 독버섯 뽑기 🎲 (1000 골드)");
                Console.WriteLine("3. 물 뿌리기 💦 (크기 + 20)");
                Console.WriteLine("4. 게임 종료 ");
                Console.Write("입력 : ");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄");
                    Console.WriteLine("🍄🍄‍🟫🍄🍄‍🟫 버섯 캐러 가는중 🍄‍🟫🍄🍄‍🟫🍄");
                    Console.WriteLine("🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄🍄‍🟫🍄");
                    Thread.Sleep(3000);

                    int eventChance = rand.Next(1, 101);            //1~100 랜덤 이벤트 발생

                    if (eventChance <= 30)                           //30% 확률로 전투 발생
                    {
                        int damage = rand.Next(5, 21);
                        Console.WriteLine($" 🦝 너구리를 만났습니다! (크기 - {damage})");
                        health -= damage;
					}
                    else if (eventChance <= 70)                      //40% 확률로 보상
                    {
                        int reward = rand.Next(300, 501);           //300~ 500 골드
                        Console.WriteLine($" 💰 골드를 발견했습니다! (+{reward} 골드)");
                        gold += reward;
					}
                    else                                            //40% 확률로 보상
                    {
                        int heal = rand.Next(10, 31);               //10~30 체력 회복
                        Console.WriteLine($" 🍄‍🟫을 발견했습니다! (+{heal} 크기)");
                        health += heal;
						
					}

                    if (health <= 0)
                    {
                        Console.WriteLine("\n 버섯이 멸종 했습니다... 게임 오버! ");
                        isAlive = false;
                    }
					Thread.Sleep(1000);
				}
                else if (input == 2)
                {
                    if (gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine(" 🎲 버섯을 뽑습니다... ");
                        Thread.Sleep(1000);

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine(" SSS급 사슴뿔버섯 (독 + 50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine(" SS급 광대버섯 (공격력 + 30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine(" S급 그냥 독버섯 (공격력 + 20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine(" 느타리버섯 (공격력 + 5) 획득!");
                            power += 5;
                        }

                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.WriteLine("골드가 부족합니다. (1000 골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다... (+ 20 크기)");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if (input == 4)
                {
					Console.WriteLine("게임 종료");
                    Environment.Exit(0);
				}
                else
                {
                    Console.WriteLine("올바른 입력이 아닙니다.");
                    Thread.Sleep(1000);
                }
            }
        
    }
}
