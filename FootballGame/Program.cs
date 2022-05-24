namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Welcome to the FootballGame v.1.0!\nPlease choose your team by entering its number...\n1.Man City\n2.Man Utd\n3.Liverpool\n4.Chelsea\n");


            List<Teams.Team> homeTeam = new List<Teams.Team>(int.Parse(Console.ReadLine()));

            
            List<string> teams = new List<string>();
            teams.Add("Man City");
            teams.Add("Man Utd");
            teams.Add("Liverpool");
            teams.Add("Chelsea");

            List<string> tactics = new List<string>();
            tactics.Add("4-4-2");
            tactics.Add("4-3-3");
            tactics.Add("3-5-2");

            Console.WriteLine($"You've choosed {teams[homeTeamId]}!\nNow.. Please choose your tactic by entering its number...\n1. 4-4-2\n2. 4-3-3\n3. 3-5-2");

            int homeTeamTacticId = int.Parse(Console.ReadLine());

            string homeTeam = teams[homeTeamId];
            teams.RemoveAt(homeTeamId);

            string awayTeam = teams[rand.Next(0, teams.Count())];


            Console.WriteLine($"Your opponent is {awayTeam}!");


        }
    }
}