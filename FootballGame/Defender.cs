
namespace FootballGame
{
    public class Defender : FootballPlayer
    {
        public Defender(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Strength = rand.Next(50, 80);
            Marking = rand.Next(Tackling, 80);
            Heading = rand.Next(50, 80);
            Jumping = rand.Next(Heading, 80);
        }

        public double TacklingPlay()
        {
            double tacklingPlay = Strength * rand.Next(30, 60) / 100 + Marking * rand.Next(30, 60) / 100 + Heading * rand.Next(30, 60) / 100 + Jumping * rand.Next(30, 60) / 100 + GeneralScore();
            return tacklingPlay;
        }

        public double PassingPlay()
        {
            double passingPlay = ShortPass * rand.Next(20, 30) / 100 + Decisions * rand.Next(20, 30) / 100 + Teamwork * rand.Next(20, 30) / 100 + GeneralScore();
            return passingPlay;
        }

        public double FinishingPlay()
        {
            double finishingPlay = Shooting * rand.Next(20, 30) / 100 + Pace * rand.Next(20, 30) / 100 + Teamwork * rand.Next(20, 30) / 100 + GeneralScore();
            return finishingPlay;
        }
        public int Marking { get; private set; }
        public int Strength { get; private set; }
        public int Heading { get; private set; }
        public int Jumping { get; private set; }

    }
}
