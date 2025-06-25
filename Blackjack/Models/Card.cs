public class Card
{
    public string Suit { get; set; }
    public string Rank { get; set; }

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;
    }

    public List<string> GetCardLines()
    {
        string rankTop;
        string rankBot;

        if (Rank == "10")
        {
            rankTop = $"│ {Rank}      │";
            rankBot = $"│      {Rank} │";
        }
        else
        {
            rankTop = $"│ {Rank}       │";
            rankBot = $"│       {Rank} │";
        }

        return new List<string>
        {
            "┌─────────┐",
            rankTop,
            "│         │",
            $"│    {Suit}    │",
            "│         │",
            rankBot,
            "└─────────┘"
        };
    }
}

