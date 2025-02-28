namespace Study18
{
    struct Rectangle //구조체 선언
    {
        public int Witdh;
        public int Height;

        public int GetArea() => Witdh * Height;
    }
    struct Point
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            // //var rect = new Rectangle { Witdh = 5, Height = 4 }; //구조체 생성 방법1
            // Rectangle rect; //구조체 생성 방법2
            // rect.Witdh = 10;
            // rect.Height = 20;

            // Console.WriteLine($"Area : {rect.GetArea()}");
            //point 부분
            Point[] points = new Point[2];

            points[0].X = 10;
            points[0].Y = 10;

            points[1].X = 20;
            points[1].Y = 20;

            foreach(var point in points)
            {
                Console.WriteLine($"Point: ({point.Y},{point.Y})");
            }
        }
    }
}