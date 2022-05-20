
namespace FootballGame
{
    public class Attacker : FootballPlayer
    {
        public Attacker(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Finishing = rand.Next(50, 100);
            Dribbling = rand.Next(50, 100);
            OffTheBall = rand.Next(50, 100);
            Acceleration = rand.Next(50, 100);
        }

        public double TacklingPlay()
        {
            double tacklingPlay = Tackling * rand.Next(10, 20) / 100 + Stamina * rand.Next(10, 20) / 100 + NaturalFitness * rand.Next(10, 20) / 100 + GeneralScore();
            return tacklingPlay;
        }

        public double PassingPlay()
        {
            double passingPlay = ShortPass * rand.Next(20, 30) / 100 + Decisions * rand.Next(20, 30) / 100 + Teamwork * rand.Next(20, 30) / 100 + GeneralScore();
            return passingPlay;
        }

        public double FinishingPlay()
        {
            double finishingPlay = Finishing * rand.Next(30, 60) / 100 + Dribbling * rand.Next(30, 60) / 100 + OffTheBall * rand.Next(30, 60) / 100 + Acceleration * rand.Next(30, 60) / 100 + GeneralScore();
            return finishingPlay;
        }
        public int Finishing { get; private set; }
        public int Dribbling { get; private set; }
        public int OffTheBall { get; private set; }
        public int Acceleration { get; private set; }


    }
}