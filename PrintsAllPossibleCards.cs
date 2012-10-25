using System;



class PrintsAllPossibleCards
{
    static string nameCard(int i) 
    {
        switch (i)
        {
            case 2: return "Deuce of";
            case 3: return "Three of";
            case 4: return "Four of";
            case 5: return "Five of";
            case 6: return "Six of";
            case 7: return "Seven of";
            case 8: return "Eight of";
            case 9: return "Nine of";
            case 10: return "Ten of";
            case 11: return "Jack of";
            case 12: return "Queen of";
            case 13: return "King of";
            case 14: return "Ace of";
            default:return "Not a card";
        }
    }

    static void nameColor(string color) 
    {
        for (int i = 2; i <= 14; i++)
        {
            Console.WriteLine(nameCard(i)+" "+color);
        }
    }

    static void Main()
    {
        nameColor("Clubs");
        nameColor("Diamonds");
        nameColor("Hearts");
        nameColor("Spades");
    }
}

