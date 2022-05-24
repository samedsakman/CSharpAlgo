namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Welcome to the FootballGame v.1.0!\nPlease choose your team by entering its number...\n1.Man City\n2.Man Utd\n3.Liverpool\n4.Chelsea\n");


            List<Teams.Team> homeTeam = new List<Teams.Team>(int.Parse(Console.ReadLine()));
            

        }
    }
}