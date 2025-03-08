namespace TEXTRPG_TEST
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MainGame mainGame = new MainGame();
            mainGame.Initialize();
            mainGame.Progress();
        }
    }
}