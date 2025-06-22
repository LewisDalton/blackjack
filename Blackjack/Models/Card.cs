public class Card
{
    private static string top = "┌─────────┐";
    private static string bottom = "└─────────┘";
    private static string side = "│         │";

    public string Suit { get; set; }
    public string Rank { get; set; }

    public Card(string rank, string suit)
    {
        Rank = rank;
        Suit = suit;

    }
    public void printCard()
    {
        string suitSide = $"│    {Suit}    │";
        string rankTop = $"│ {Rank}       │";
        string rankBot = $"│       {Rank} │";
        string cardString = top + "\n" + rankTop + "\n" + side + "\n" + suitSide + "\n" + side + "\n" + rankBot + "\n" + bottom;
        Console.WriteLine(cardString);
    }

    public static string returnCard(int amount)
    {
        string cardString = top + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + bottom;
        return cardString;
    }

    // public static List<string> returnCards(int amount)
    // {
    //     /*  
    //     get amount of cards
    //     return that amount of cards in a list

    //     */
    //     List<string> cards = new List<string>();
    //     string cardString = "\n" + top + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + bottom + "\n";
    //     for (int i = 0; i < amount; i++)
    //     {
    //     cards.Add(cardString);
    //     }
    //     return cards;
    // }
}

