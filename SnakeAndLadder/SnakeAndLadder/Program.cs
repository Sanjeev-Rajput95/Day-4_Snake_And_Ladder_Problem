namespace SnakeAndLadder
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Welcome to the Snake and Ladder Program------- ");

            Day4Problem day4ProblemObj = new Day4Problem();

            //  day4ProblemObj.singlePlayer();

            //  day4ProblemObj.firstDiceRoll();
            day4ProblemObj.snakeAndLadder();
        }
    }
}