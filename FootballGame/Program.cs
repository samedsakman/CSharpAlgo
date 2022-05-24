namespace FootballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.Write("Welcome to the FootballGame v.1.0!\nPlease choose your team by entering its number...\n1.Man City\n2.Man Utd\n3.Liverpool\n4.Chelsea\n");

            int homeTeamId = int.Parse(Console.ReadLine());
            string homeTeam = "";

            List<string> teams = new List<string>();
            teams.Add("Man City");
            teams.Add("Man Utd");
            teams.Add("Liverpool");
            teams.Add("Chelsea");

            for (int i = 0; i <= teams.Count; i++)
            {
                if (homeTeamId == i)
                    homeTeam = teams[rand.Next(i + 1, teams.Count)];
                else
                    break;

            }
        }
    }
}