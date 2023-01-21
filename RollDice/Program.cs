namespace RollDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diceRollTime = 0;
            bool play = true;

            Console.WriteLine("WELCOME!");

            while (play==true)
            {
                Console.WriteLine("One or Two Dice?\nOne --> 1\nTwo --> 2");
                var PlayerChoice = Convert.ToInt32(Console.ReadLine());
                Random diceOneRnd = new Random();
                int diceOne = diceOneRnd.Next(1, 6);

                Random diceTwoRnd = new Random();
                int diceTwo = diceOneRnd.Next(1, 6);


                if (PlayerChoice == 1)
                {
                    Console.WriteLine($"Dice one: {diceOne}");
                    Console.WriteLine();
                    ++diceRollTime;
                }
                if (PlayerChoice == 2)
                {
                    Console.WriteLine($"Dice one: {diceOne}");
                    Console.WriteLine();
                    Console.WriteLine($"Dice Tne: {diceTwo}");
                    Console.WriteLine();
                    ++diceRollTime;
                }

                Console.WriteLine("Choice Again?\ny/n");
                var yesOrNoSelection = Console.ReadLine();

                if (yesOrNoSelection == "n")
                {
                    Console.WriteLine("GoodBye...");
                    play = false;
                } 
            }
        }
    }
}