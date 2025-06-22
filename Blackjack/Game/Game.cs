class Game
{
    private int bet;
    private List<Card> playerHand = new List<Card>();
    private List<Card> dealerHand = new List<Card>();
    private Deck deck;
    private Random random = new Random();

    public void GameLoop()
    {
        // Console.Write("Welcome to blackjack.\nPlease enter your bet: ");
        // bet = int.Parse(Console.ReadLine());
        deck = new Deck();
        Deal();
    }

    public void Deal()
    {
        Console.WriteLine("\nDealing Cards:");

        // if no cards have been removed from the deck deal two cards and remove them from the deck
        deck.cards[random.Next(0, deck.cards.Count)].printCard();
        deck.cards[random.Next(0, deck.cards.Count)].printCard();
    }

    private void Hit()
    {

    }

    private void Stand()
    {

    }
}
