class Card()
{
    private static string top = "┌─────────┐";
    private static string bottom = "└─────────┘";
    private static string side = "│         │";

    public static void printCard()
    {
        string cardString = top + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + bottom;
        Console.WriteLine(cardString);
    }

    public static string returnCard(int amount)
    {
        string cardString = top + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + bottom;
        return cardString;
    }

    public static List<string> returnCards(int amount)
    {
        /*  
        get amount of cards
        return that amount of cards in a list

        */
        List<string> cards = new List<string>();
        string cardString = "\n" + top + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + side + "\n" + bottom + "\n";
        for (int i = 0; i < amount; i++)
        {
        cards.Add(cardString);
        }
        return cards;
    }
}

