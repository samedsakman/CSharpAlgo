using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class FootballPlayer
    {
        public Random rand = new Random();

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
        
        public double GeneralScore()
        {
            double generalScore = ShortPass * (rand.Next(1, 4)) / 10 + Tackling * (rand.Next(1, 4)) / 10 + Shooting * (rand.Next(1, 4)) / 10 + Decisions * (rand.Next(1, 4)) / 10 + Teamwork * (rand.Next(1, 4)) / 10 + Pace * (rand.Next(1, 4)) / 10 + Stamina * (rand.Next(1, 4)) / 10 + NaturalFitness * rand.Next(1, 4) / 10;
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
