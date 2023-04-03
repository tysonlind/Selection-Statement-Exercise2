namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite color?");
            var userColor = Console.ReadLine();
            switch (userColor)
            {
                case "blue":
                    Console.WriteLine("Your favorite color was blue");
                        break;
                case "red":
                    Console.WriteLine("Your favorite color was red");
                    break;
                default:
                    Console.WriteLine("Your favorite color was not one of the switch cases");
                    break;

            }
        }
    }
}