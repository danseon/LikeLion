namespace _250305babylion
{

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while(true)
            {
            Console.WriteLine("가위,바위,보 : (1)가위 (2)바위 (3)보");
            int userint = int.Parse(Console.ReadLine());
            int rndint = rnd.Next(1,4);
            if(userint == rndint)
            {
                Console.WriteLine("비겼습니다.");
            }
            else if(userint == 1 && rndint == 2)
            {
                Console.WriteLine("바위에게 졌습니다.");
            }
            else if (userint == 1 && rndint == 3)
            {
                Console.WriteLine("보에게 이겼습니다.");
            }
            else if(userint == 2 && rndint == 1)
            {
                Console.WriteLine("가위에게 이겼습니다.");
            }
            else if (userint == 2 && rndint == 3)
            {
                Console.WriteLine("보에게 졌습니다.");
            }
            else if (userint == 3 && rndint == 1)
            {
                Console.WriteLine("바위에게 이겼습니다.");
            }
            else if(userint == 3 && rndint == 2)
            {
                Console.WriteLine("바위에게 이겼습니다.");
            }
            }
        }
    }
}