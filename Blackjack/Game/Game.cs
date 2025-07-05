class Game
{
    private int bet;
    private Deck deck = new Deck();
    private Dealer dealer = new Dealer();
    private Player player = new Player();
    private Random random = new Random();
    private bool gameOver = false;

    public void GameLoop()
    {
        Console.Write("Welcome to blackjack.\nPlease enter your bet: \n");
        // bet = int.Parse(Console.ReadLine());

        Deal();

        Console.WriteLine("Would you like to hit (h) or stand? (s)\n");
        string input = Console.ReadLine();
        while (gameOver == false)
        {
            if (input == "h")
            {
                Hit();
            }
            else if (input == "s")
            {
                Console.WriteLine("You are standing");
                DealerHit();
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
            player.CleanHand();
            dealer.CleanHand();
            Console.WriteLine("Would you like to hit (h) or stand? (s)\n");
            input = Console.ReadLine();
        }
    }

    public void Deal()
    {
        // if no cards have been removed from the deck deal two cards and remove them from the deck
        if (dealer.hand.Count == 0 && player.hand.Count == 0)
        {
            dealer.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            dealer.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            dealer.PrintHand();

            player.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            player.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            player.PrintHand();
        }
        else
        {
            Console.WriteLine("The dealer and players hand has not been emptied");
        }
    }

    private void Hit()
    // It would be a good idea to have the hit be one function with a argument for which object is "hitting" i.e. player or dealer
    {
        player.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
        player.PrintHand();
    }

    private void DealerHit()
    {
        Console.WriteLine("Hit dealer");
        while (dealer.handNum < 17)
        {
            dealer.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            dealer.PrintHand();
        }
    }
}
