
namespace FootballGame
{
    public class GoalKeeper : FootballPlayer
    {
        public GoalKeeper(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Handling = rand.Next(60, 100);
            Reflexes = rand.Next(60, 100);
            AerialAbility = rand.Next(Handling, 100);
            OneAndOnes = rand.Next(Reflexes, 100);
        }

        public double SavingPlay()
        {
            double savingPlay = Handling * rand.Next(30, 60) / 100 + Reflexes * rand.Next(30, 60) / 100 + AerialAbility * rand.Next(30, 60) / 100 + OneAndOnes * rand.Next(30, 60) / 100 + GeneralScore();
            return savingPlay;
        }

        public double PassingPlay()
        {
            double passingPlay = ShortPass * rand.Next(20, 30) / 100 + Decisions * rand.Next(20, 30) / 100 + Teamwork * rand.Next(20, 30) / 100 + GeneralScore();
            return passingPlay;
        }

        public int Handling { get; private set; }
        public int Reflexes { get; private set; }
        public int AerialAbility { get; private set; }
        public int OneAndOnes { get; private set; }

    }
}
