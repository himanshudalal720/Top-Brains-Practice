using System;
public class CricketMatch
{
    public int[] playerScores = new int[5];
    public int currentIndex = 0;
    public void AddPlayerScore(int score)
    {
        if (score < 0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }
        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 players scores.");
        }
        playerScores[currentIndex] = score;
        currentIndex++;
    }
    public int CalculateTotalScore()
    {
        int total = 0;
        for (int i = 0; i < currentIndex; i++)
        {
            total += playerScores[i];
        }
        return total;
        }
}
