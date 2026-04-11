using System;

public class Team : IComparable<Team>
{
    public string Name { get; set; }
    public int Points { get; set; }

    public int CompareTo(Team other)
    {
        if (other == null) return 1;

        // Compare by points (descending)
        int pointComparison = other.Points.CompareTo(this.Points);

        if (pointComparison != 0)
            return pointComparison;

        // If points equal → compare by name (ascending)
        return this.Name.CompareTo(other.Name);
    }

    public override string ToString()
    {
        return $"{Name} - {Points} pts";
    }
}
