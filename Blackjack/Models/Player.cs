public class Player
{
    public List<Card> hand = new List<Card>();

    public Player()
    {
    }

    public void PrintHand()
    {
        Console.WriteLine("\nPlayers Hand: ");
        foreach (Card card in hand)
        {
            card.printCard();
        }
    }
}
