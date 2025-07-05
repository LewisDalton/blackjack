public class Player
{
    public List<Card> hand = new List<Card>();
    public List<Card> handClean = new List<Card>();
    public int handNum = 0;

    public Player()
    {
    }

    public void AddCard(Card card)
    {
        hand.Add(card);
    }

    // hit -> add card to hand -> translate hand -> is hand more than 21
    // problem is that when translating the cards its looping over the whole list every time.


    public void CleanHand()
    {
        // loop through the non-translated hand (i.e "King" does not mean "10" yet)
        // translate the card to its value
        // append it as an integer to the handNum variable

        handNum = 0; // reset handNum to avoid appending values already there (bad temp fix)
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
        // check if a card is king, queen, jester or ace. if yes swap it to the correct value
        // CURRENTLY DOES NOT HANDLE ACE CHOICE
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
        Console.WriteLine("\nPlayers Hand: ");
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
