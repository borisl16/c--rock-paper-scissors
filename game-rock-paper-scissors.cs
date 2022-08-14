{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String bot;

            while (playAgain)
            {
                player = "";
                computer = "";

                while (player != "ROCK" player != "PAPER" player != "SCISSORS") {
                    Console.Write("Choose wisely: ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }
                Console.Write(player);
            }

            Console.ReadKey();
        }

    }
}