
namespace FootballGame
{
    public class FootballPlayer
    {
        protected Random rand = new Random();

        public FootballPlayer(string fullName, int shirtNumber)
        {
            ShortPass = rand.Next(50, 90);
            Tackling = rand.Next(50, 90);
            Shooting = rand.Next(50, 90);
            Decisions = rand.Next(50, 90);
            Teamwork = rand.Next(50, 90);
            Pace = rand.Next(50, 90);
            Stamina = rand.Next(50, 90);
            NaturalFitness = rand.Next(50, 90);

            FullName = fullName;
            if (shirtNumber > 0 && shirtNumber < 100)
                ShirtNumber = shirtNumber;
            else
                Console.WriteLine("Shirt number must be between 1 and 99");
        }

        protected double GeneralScore()
        {
            double generalScore = ShortPass * (rand.Next(10, 40)) / 100 + Tackling * (rand.Next(10, 40)) / 100 + Shooting * (rand.Next(10, 40)) / 100 + Decisions * (rand.Next(10, 40)) / 100 + Teamwork * (rand.Next(10, 40)) / 100 + Pace * (rand.Next(10, 40)) / 100 + Stamina * (rand.Next(10, 40)) / 100 + NaturalFitness * rand.Next(10, 40) / 100;
            return generalScore;
        }

        public string FullName { get; private set; }
        public int ShirtNumber { get; private set; }
        public int ShortPass { get; private set; }
        public int Tackling { get; private set; }
        public int Shooting { get; private set; }
        public int Decisions { get; private set; }
        public int Teamwork { get; private set; }
        public int Pace { get; private set; }
        public int Stamina { get; private set; }
        public int NaturalFitness { get; private set; }
    }

}
