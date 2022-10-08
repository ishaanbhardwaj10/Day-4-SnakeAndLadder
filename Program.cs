namespace SnakeAndLadder
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator");
            Console.WriteLine("Use case #1: Single Player at Position Zero");

            Console.Write("Choose a use case number to run the program: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    SinglePlayerPositionZero.Play();
                    Console.WriteLine("Player One ready to play, starting at position 0");
                    break;
                default:
                    Console.WriteLine("Please enter a valid use case number!");
                    break;
            }
            
        }
    }
}