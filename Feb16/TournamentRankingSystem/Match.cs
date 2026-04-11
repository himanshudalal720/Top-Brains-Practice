public class Match
{
    public Team Team1 { get; }
    public Team Team2 { get; }

    public int Team1Score { get; set; }
    public int Team2Score { get; set; }

    public Match(Team team1, Team team2)
    {
        Team1 = team1;
        Team2 = team2;
    }

    // Clone for undo functionality
    public Match Clone()
    {
        return new Match(Team1, Team2)
        {
            Team1Score = this.Team1Score,
            Team2Score = this.Team2Score
        };
    }
}
