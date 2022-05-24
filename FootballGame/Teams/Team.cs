using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballGame.Teams
{
    internal class Team
    {
        Manager _managerReputation;
        List<string> _teamName;
        int _tacticId;
        int _teamReputationMultiplier;

        public List<string> TeamName
        {
            get { return _teamName; }
            set 
            {   _teamName.Add("Man City");
                _teamName.Add("Man Utd");
                _teamName.Add("Liverpool");
                _teamName.Add("Chelsea");
            }
        }
        public Team (int teamId)
        {
            _teamName[teamId]
        }
        
        
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
