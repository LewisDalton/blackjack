public class Dealer
{
    public List<Card> hand = new List<Card>();
    public int handTotal = 0;

    public Dealer()
    {
    }

    public void AddCard(Card card)
    {
        hand.Add(card);
        
    }

    public void PrintHand()
    {
        Console.WriteLine("\nDealers Hand: ");
        foreach (Card card in hand)
        {
            card.printCard();
        }
    }

}
