using System.Globalization;

class Game
{
    private int bet;
    private Deck deck = new Deck();
    private Dealer dealer = new Dealer();
    private Player player = new Player();
    private Random random = new Random();

    public void GameLoop()
    {
        Console.Write("Welcome to blackjack.\nPlease enter your bet: \n");
        // bet = int.Parse(Console.ReadLine());
        Deal();

        Console.Write("");


    }

    public void Deal()
    {
        // if no cards have been removed from the deck deal two cards and remove them from the deck
        List<string> tmp = new List<string>();
        tmp.Add("something");
        if (dealer.hand.Count == 0 && player.hand.Count == 0)
        {
            dealer.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            dealer.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            dealer.PrintHand();

            // player.AddCard(deck.cards[random.Next(0, deck.cards.Count)]);
            // player.PrintHand();
        }
        else
        {
            Console.WriteLine("The dealer and players hand has not been emptied");
        }
    }

    private void Hit()
    {

    }

    private void Stand()
    {

    }
}
