namespace Delegate
{

    class Program
    {
        //델리게이트 정의 - 메시지 출력을 위한 메서드 참조
        //string 매개변수를 받고 반환값이 없는 (void) 매서드를 참조 할 수 있는 타입
        //함수를 가리키는 포인터!
        delegate void MessageHandler(string message);

        //델리게이트에 연결할 메서드
        //메서드 형과 타입이 일치해야 받을 수 있다
        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메세지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메시지: {message.ToUpper()}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("==간단한 델리게이트와 이벤트 예제");

            //1. 델리게이트 사용해보기
            Console.WriteLine("델리게이트1");

            //델리게이트 변수 선언 및 메서드 연결
            //DisplayMessage 매서드를 MessageHandler 변수에 할당
            MessageHandler messageHandler = DisplayMessage;

            //델리게이트 호출 - 연결된 매서드가 실행됨
            messageHandler("안녕하세요");

            //델리게이트에 다른 메서드 추가 (멀티캐스트 델리케이트)
            // += 연산자로 메서드 추가
            messageHandler += DisplayUpperMessage;

            //여러 매서드가 연결된 델리게이트 호출
            //등록된 모든 메서드가 순서대로 호출된다.
            Console.WriteLine("여러 매서드 호출: ");
            messageHandler("Hello ");
        }
    }
}