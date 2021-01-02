using System;
using System.Collections.Generic;

namespace _05.TeamWorkProject
{
    public class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Member { get; set; }

        public Team(string teamName, string teamCreator)
        {
            this.TeamName = teamName;
            this.Creator = teamCreator;
        }
        public Team()
        {

        }
    }
}
