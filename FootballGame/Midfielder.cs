
namespace FootballGame
{
    public class Midfielder : FootballPlayer
    {
        public Midfielder(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            LongPass = rand.Next(50, 80);
            FirstTouch = rand.Next(50, 80);
            Positioning = rand.Next(50, 80);
            Technique = rand.Next(50, 80);
        }

        public double TacklingPlay()
        {
            double tacklingPlay = Tackling * rand.Next(20, 30) / 100 + Stamina * rand.Next(20, 30) / 100 + NaturalFitness * rand.Next(20, 30) / 100 + GeneralScore();
            return tacklingPlay;
        }

        public double PassingPlay()
        {
            double passingPlay = LongPass * rand.Next(30, 60) / 100 + FirstTouch * rand.Next(30, 60) / 100 + Positioning * rand.Next(30, 60) / 100 + Technique * rand.Next(30, 60) / 100 + GeneralScore();
            return passingPlay;
        }

        public double FinishingPlay()
        {
            double finishingPlay = Shooting * rand.Next(10, 20) / 100 + Pace * rand.Next(10, 20) / 100 + Teamwork * rand.Next(10, 20) / 100 + GeneralScore();
            return finishingPlay;
        }

        public int LongPass { get; private set; }
        public int FirstTouch { get; private set; }
        public int Positioning { get; private set; }
        public int Technique { get; private set; }

    }
}