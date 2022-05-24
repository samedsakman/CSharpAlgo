using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Teams
{
    internal class Manager : Team
    {
        public Manager(int teamId) : base(teamId)
        {
            if (teamId == 1)
                ReputationMultiplier = 0.2;
            else if (teamId == 2)
                ReputationMultiplier = 0.3;
            else if (teamId == 3)
                ReputationMultiplier = 0.1;
            else
                ReputationMultiplier = 0.1;
           
        }

        public string ManagerName { get; set; }
        public double ReputationMultiplier { get; set; }
    }
}
