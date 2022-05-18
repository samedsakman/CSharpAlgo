using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class Defender : FootballPlayer
    {
        public Defender(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Random rand = new Random();
            Tackling = rand.Next(50, 100);
            Strength = rand.Next(Tackling, 100);
            Heading = rand.Next(50, 100);
            Jumping = rand.Next(Heading, 100);
        }

        public double TacklingPlay()
        {
            double tacklingPlay = GeneralScore() + Tackling * 0.5 + Strength * 0.5 + Heading * 0.3 + Jumping * 0.3;
            return tacklingPlay;
        }
        public int Tackling { get; set; }
        public int Strength { get; set; }
        public int Heading { get; set; }
        public int Jumping { get; set; }

    }
}
