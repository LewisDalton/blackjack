public class Dealer
{
    public List<Card> hand = new List<Card>();
    public int handTotal = 0;
    public int handNum = 0;

    public Dealer()
    {
    }

    public void AddCard(Card card)
    {
        hand.Add(card);
    }

    public void CleanHand()
    {
        handNum = 0;
        foreach (Card i in hand)
        {
            TranslateRank(i);
            string cardRank = i.Rank;
            handNum += int.Parse(cardRank);
        }
        Console.WriteLine(handNum);
    } 

    private void TranslateRank(Card card)
    {
        switch (card.Rank)
        {
            case "K":
            case "Q":
            case "J":
                card.Rank = "10";
                break;
            case "A":
                card.Rank = "1";
                break;
            default:
                break;
        }
    }

    public void PrintHand()
    {
        Console.WriteLine("\nDealers Hand: ");
        foreach (Card card in hand)
        {
            card.GetCardLines();
            List<string> temp = card.GetCardLines();
            for (int i = 0; i < temp.Count; i++)
            {
                Console.Write($"{temp[i]}\n");
            }
        }
        Console.WriteLine();
    }

}
