using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            List<Team> teams = new List<Team>();

            string command = "";

            int numberOfTeams = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfTeams; i++)
            {
                string[] teamInformation = Console.ReadLine().Split("-");

                string teamCreator = teamInformation[0];
                string teamName = teamInformation[1];

                if (teams.Select(t=>t.TeamName).Contains(teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Select(c=>c.Creator).Contains(teamCreator))
                {
                    Console.WriteLine($"{teamCreator} cannot create another team!");
                }
                else
                {
                    Team currTeam = new Team(teamName, teamCreator);
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {teamName} has been created by {teamCreator}!");
                }
    
            }
            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] joinTeamUsers = command.Split("->");

                string newMember = joinTeamUsers[0];
                string wantedTeam = joinTeamUsers[1];

                if (!teams.Any(w => w.TeamName == wantedTeam))
                {
                    Console.WriteLine($"Team {wantedTeam} does not exist!");
                }
                else if (teams.Any(c => c.Creator == newMember) || teams.Any(m => m.Member.Contains(newMember)))
                {
                    Console.WriteLine($"Member {newMember} cannot join team {wantedTeam}!");
                }
                else
                {
                    team.Member.Add(newMember);
                }
            }
            List<Team> teamWithMember = teams
                .Where(m => m.Member.Count > 0)
                .OrderByDescending(c => c.Member.Count)
                .ThenBy(t => t.TeamName)
                .ToList();

            List<Team> invalidTeam = teams
                .Where(m => m.Member.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            foreach (var team1 in teamWithMember)
            {
                Console.WriteLine($"{team.TeamName}{Environment.NewLine}- {team.Creator}{Environment.NewLine}-- {string.Join(Environment.NewLine, team.Member)}");
            }
        }
    }
}
