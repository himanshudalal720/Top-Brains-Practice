using System;
using System.Collections.Generic;
using System.Linq;

public class Tournament
{
    private SortedList<int, Team> _rankings = new SortedList<int, Team>();
    private LinkedList<Match> _schedule = new LinkedList<Match>();
    private Stack<Match> _undoStack = new Stack<Match>();

    private List<Team> _teams = new List<Team>();

    // Add match to schedule
    public void ScheduleMatch(Match match)
    {
        _schedule.AddLast(match);

        if (!_teams.Contains(match.Team1))
            _teams.Add(match.Team1);

        if (!_teams.Contains(match.Team2))
            _teams.Add(match.Team2);

        UpdateRankings();
    }

    // Record match result and update rankings
    public void RecordMatchResult(Match match, int team1Score, int team2Score)
    {
        _undoStack.Push(match.Clone());

        match.Team1Score = team1Score;
        match.Team2Score = team2Score;

        if (team1Score > team2Score)
            match.Team1.Points += 3;
        else if (team1Score < team2Score)
            match.Team2.Points += 3;
        else
        {
            match.Team1.Points += 1;
            match.Team2.Points += 1;
        }

        UpdateRankings();
    }

    // Undo last match
    public void UndoLastMatch()
    {
        if (_undoStack.Count == 0)
        {
            Console.WriteLine("No match to undo.");
            return;
        }

        Match lastMatch = _undoStack.Pop();

        // Revert points
        if (lastMatch.Team1Score > lastMatch.Team2Score)
            lastMatch.Team1.Points -= 3;
        else if (lastMatch.Team1Score < lastMatch.Team2Score)
            lastMatch.Team2.Points -= 3;
        else
        {
            lastMatch.Team1.Points -= 1;
            lastMatch.Team2.Points -= 1;
        }

        UpdateRankings();
    }

    // Rebuild SortedList based on updated team points
    private void UpdateRankings()
    {
        _rankings.Clear();

        var sortedTeams = _teams.OrderBy(t => t).ToList();

        for (int i = 0; i < sortedTeams.Count; i++)
        {
            _rankings.Add(i, sortedTeams[i]);
        }
    }

    // Get ranking position using binary search
    public int GetTeamRanking(Team team)
    {
        var teams = _rankings.Values.ToList();
        int index = teams.BinarySearch(team);
        return index >= 0 ? index + 1 : -1;
    }

    public IList<Team> GetRankings()
    {
        return _rankings.Values.ToList();
    }
}
