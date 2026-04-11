using System;

class Program
{
    static void Main()
    {
        Tournament tournament = new Tournament();

        Team teamA = new Team { Name = "Team Alpha", Points = 0 };
        Team teamB = new Team { Name = "Team Beta", Points = 0 };

        Match match = new Match(teamA, teamB);

        tournament.ScheduleMatch(match);

        tournament.RecordMatchResult(match, 3, 1); // Team A wins

        var rankings = tournament.GetRankings();
        Console.WriteLine("Top Team: " + rankings[0].Name); 
        // Should output: Team Alpha

        tournament.UndoLastMatch();
        Console.WriteLine("Team Alpha Points After Undo: " + teamA.Points);
        // Should output: 0
    }
}
