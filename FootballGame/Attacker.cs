using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Attacker : FootballPlayer
    {
        public Attacker(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Finishing = rand.Next(50, 100);
            FirstTouch = rand.Next(50, 100);
            Heading = rand.Next(50, 100);
            LongShots = rand.Next(50, 100);
        }
        
        public double ShootingPlay()
        {
            double shootingPlay = GeneralScore() + Finishing * 0.5 + FirstTouch * 0.5 + Heading * 0.3 + LongShots * 0.3;
            return shootingPlay;
        }
        public int Finishing { get; set; }
        public int FirstTouch { get; set; }
        public int Heading { get; set; }
        public int LongShots { get; set; }


    }
}