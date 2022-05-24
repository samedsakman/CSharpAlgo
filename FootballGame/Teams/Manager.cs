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
           
        }

        public string ManagerName { get; set; }
        public int ReputationMultiplier { get; set; }
    }
}
