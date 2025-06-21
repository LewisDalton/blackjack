class Game()
{
    private int bet;
    private List<string> playerHand = new List<string>();
    private List<string> dealerHand = new List<string>();

    public void Loop()
    {
        Console.WriteLine("Welcome to blackjack.\n Please enter your bet: ");
        bet = int.Parse(Console.ReadLine());
        Deal();

    }

    private void Deal()
    {
        List<string> temp = Card.returnCards(3);
        Console.WriteLine(string.Join(", ", temp)); }
}
