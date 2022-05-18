using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Midfielder : FootballPlayer
    {
        public Midfielder(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Random rand = new Random();
            ShortPass = rand.Next(60, 100);
            FirstTouch = rand.Next(60, 100);
            Dribbling = rand.Next(60, 100);
            Technique = rand.Next(60, 100);
        }

        public double PassingPlay()
        {
            double passingPlay = GeneralScore() + ShortPass * 0.5 + FirstTouch * 0.5 + Dribbling * 0.3 + Technique * 0.3;
            return passingPlay;
        }
        public int ShortPass { get; set; }
        public int FirstTouch { get; set; }
        public int Dribbling { get; set; }
        public int Technique { get; set; }

    }
}