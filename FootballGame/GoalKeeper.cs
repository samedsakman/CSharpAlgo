using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame
{
    public class GoalKeeper : FootballPlayer
    {
        public GoalKeeper(string fullName, int shirtNumber) : base(fullName, shirtNumber)
        {
            Random rand = new Random();
            Handling = rand.Next(60, 100);
            Reflexes = rand.Next(60, 100);
            AerialAbility = rand.Next(Handling, 100);
            OneAndOnes = rand.Next(Reflexes, 100);
            
        }

        public double SavingPlay()
        {
            double savingPlay = GeneralScore() + Handling * 0.5 + Reflexes * 0.5 + AerialAbility * 0.3 + OneAndOnes * 0.3;
            return savingPlay;
        }

        public int Handling { get; set; }
        public int Reflexes { get; set; }
        public int AerialAbility { get; set; }
        public int OneAndOnes { get; set; }

    }
}
