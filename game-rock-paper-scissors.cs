{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String bot;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";


                while (player != "ROCK" player != "PAPER" player != "SCISSORS") {
                    Console.Write("Choose wisely: ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch ( random.Next(1,4))
                {
                    case 1:
                        bot = "ROCK"; break;
                    case 2:
                        bot = "PAPER"; break;
                    case 3:
                        bot = "SCISSORS"; break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + bot);

                switch (player)
                {
                    case "ROCK":
                        if (bot = "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (bot == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;

                        case "PAPER":
                        if (computer = "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;

                        case "SCISSORS":
                        if (bot  = "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (bot == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }
                Console.Write("Are you up to for one more game (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.toUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Good game, thanks for playing!")

            Console.ReadKey();
        }

    }
}