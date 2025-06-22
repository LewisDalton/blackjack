public class Deck
{
    // Get an array of card objects
    public List<Card> cards = new List<Card>();

    public Deck()
    {
        SetDeck();
    }

    public void PrintDeck()
    {
        Console.WriteLine(cards.Count);
    }

    public void SetDeck()
    {
        string[] suits = { "♥", "♦", "♣", "♠" };
        string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

        foreach (string suit in suits)
        {
            foreach (string rank in ranks)
            {
                cards.Add(new Card(rank, suit));
            }
        }
    }
}
