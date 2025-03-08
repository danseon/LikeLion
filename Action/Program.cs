namespace Action1
{
    //델리게이트와 이벤트를 더 쉽게 만든 Action

    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요");
        }
        static void ShowNotification()
        {
            Console.WriteLine("중요한 알림이 있습니다.");
        }
        static void HelloWorld(string message)
        {
            Console.WriteLine("신규메시지 : " + message);
        }
        static void Main(string[] args)
        {
            Action sayHello = SayHello;

            sayHello += ShowNotification;

            sayHello?.Invoke();

            Action<string> h = null;

            h += HelloWorld;

            h?.Invoke("이게 액션이다.");

            Action noti = null;

            noti += () => Console.WriteLine("인자없는 액션이다.");

            noti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number * number);

            Square(5);
        }
    }
}