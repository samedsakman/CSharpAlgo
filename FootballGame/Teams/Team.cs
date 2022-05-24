using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Teams
{
    internal class Team
    {
        Random rand = new Random();

        Manager _managerReputation;

        public Team (int teamId)
        {

        }
        
        public string TeamName { get; set; }
        public int TacticId { get; set; }
        public int TeamReputationMultiplier { get; set; }
        public Manager ManagerReputationMultiplier 
        { 
            get
            {
                return ManagerReputationMultiplier;
            }
            set
            {
                ManagerReputationMultiplier = _managerReputation.ManagerReputationMultiplier;
            }
        }

    }
}
