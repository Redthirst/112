namespace PokerHand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> deck = new() 
            { 
                "2c", "3c", "4c", "5c", "6c", "7c", "8c", "9c", "10c", "Jc", "Qc", "Kc", "Ac", 
                "2d", "3d", "4d", "5d", "6d", "7d", "8d", "9d", "10d", "Jd", "Qd", "Kd", "Ad", 
                "2h", "3h", "4h", "5h", "6h", "7h", "8h", "9h", "10h", "Jh", "Qh", "Kh", "Ah", 
                "2s", "3s", "4s", "5s", "6s", "7s", "8s", "9s", "10s", "Js", "Qs", "Ks", "As" 
            };

            List<Players> pl = new() { new Players("Arthur"), new Players("Eugene"), new Players("Frank") };

            do
            {
                List<string> playdeck = deck.ToList();
                List<Cards> comm = Cards.CommunityCards(playdeck);
                foreach (Players p in pl)
                {
                    p.NewHand(playdeck);
                    p.ChangeTokens();
                }
                foreach (Players p in pl)
                {
                    p.PokerHandRankings(pl, comm);
                }
                Console.WriteLine(Players.CompareScore(pl));
                Players.ClearScore(pl);
                foreach (Players p in pl)
                {
                    if (p.PrintTokens() == 0)
                    {
                        Console.WriteLine($"{p.Name} has been eliminated!");
                        pl.Remove(p);
                        break;
                    }
                }
            }
            while (Console.ReadKey().Key == ConsoleKey.Enter);
            //while (pl.Count >= 2);
            //Console.WriteLine($"{pl[0].Name} is the winner!");
        }
        
    }
    public class Cards
    {
        public string Face { get; }
        public string Suit { get; }
        public int Faceenum { get; }
        public string FullFace { get; }
        public string FullFacePl { get; }
        public string Card { get; }
        public enum Faces
        {
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            J = 11,
            Q = 12,
            K = 13,
            A = 14,   
        }
        public Cards(string card)
        {
            Card = card;
            Suit = card.Substring(card.Length - 1);
            Face = card.Substring(0, card.Length - 1);
            Enum.TryParse<Faces>(Face, out Faces face1);
            Faceenum = (int)face1;
            switch (Face)
            {
                case "2": FullFace = "Two";
                    FullFacePl = FullFace;
                    break;
                case "3": FullFace = "Three";
                    FullFacePl = FullFace;
                    break;
                case "4":
                    FullFace = "Four";
                    FullFacePl = FullFace;
                    break;
                case "5":
                    FullFace = "Five";
                    FullFacePl = FullFace;
                    break;
                case "6":
                    FullFace = "Six";
                    FullFacePl = "Sixe";
                    break;
                case "7":
                    FullFace = "Seven";
                    FullFacePl = FullFace;
                    break;
                case "8":
                    FullFace = "Eight";
                    FullFacePl = FullFace;
                    break;
                case "9":
                    FullFace = "Nine";
                    FullFacePl = FullFace;
                    break;
                case "10":
                    FullFace = "Ten";
                    FullFacePl = FullFace;
                    break;
                case "J":
                    FullFace = "Jack";
                    FullFacePl = FullFace;
                    break;
                case "Q":
                    FullFace = "Queen";
                    FullFacePl = FullFace;
                    break;
                case "K":
                    FullFace = "King";
                    FullFacePl = FullFace; 
                    break;
                case "A":
                    FullFace = "Ace";
                    FullFacePl = FullFace;
                    break;
            }
        }
        public int PrintFace()
        {
            return Faceenum;
        }
        public string PrintSuit()
        {
            return Suit;
        }
        public string PrintFullFace()
        {
            return FullFace;
        }
        public string PrintFullFacePl()
        {
            return FullFacePl;
        }
        public static Cards ReturnCard(List<Cards> list, int card)
        {
            foreach(Cards c in list)
            {
                if (c.PrintFace() == card)
                {
                    return c;
                }
            }
            return null;
        }
        public static List<int> ReturnCard(List<Cards> list)
        {
            List<int> ot = new();
            foreach(Cards c in list)
            {
                ot.Add(c.PrintFace());
            }
            return ot;
        }
        public static List<Cards> CommunityCards(List<string> list)
        {
            List<Cards> hand = new();
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int n = rnd.Next(0, list.Count - 1);
                hand.Add(new(list[n]));
                list.RemoveAt(n);
            }
            return hand;
        }
    }
    public class Players
    {
        public string Name { get; }
        private int Tokens { get; set; } = 10;
        private string[] Hand { get; set; }
        private int[] CardScore { get; set; }
        private string FullFace { get; set; }
        private string WinCard { get; set; }
        public enum CardScores
        {
            HighCard = 1,
            Pair = 2,
            TwoPairs = 3,
            ThreeOfAKind = 4,
            Straight = 5,
            Flush = 6,
            FullHouse = 7,
            FourOfAKind = 8,
            StraightFlush = 9,
            RoyalFlush = 10,
        }

        public Players(string name)
        {
            Name = name;
            CardScore = new int[2] { 0, 0 };
            
        }
        public void NewHand(List<string> list) // Creates a new hand for specified player based on the deck
        {
            string[] hand = new string[2];
            Random rnd = new Random();
            for (int i = 0; i < 2; i++)
            {
                int n = rnd.Next(0, list.Count - 1);
                hand[i] = list[n];
                list.RemoveAt(n);
            }
            Hand = hand;
        }
        public void SetScore(int[] score)
        {
            CardScore = score;
        }
        public int[] GetScore()  // Score is contained in an array. First number - hand type, second number - card type
        {
            return CardScore;
        }
        public static void ClearScore(List<Players> list)
        {
            foreach(Players p in list)
            {
                p.CardScore = new int[2] { 0, 0 };
            }
        }
        public void ChangeTokens(int score)
        {     
             Tokens += score;   
        }
        public void ChangeTokens()
        {
            Tokens--;
        }
        public int PrintTokens()
        {
            return Tokens;
        }
       
        public static string CompareScore(List<Players> list)  // Compares scores from a list of player using some LINQ stuff
        {
            IEnumerable<Players> sortedscore =
                from p in list
                orderby p.GetScore()[0] descending, p.GetScore()[1] descending
                select p;
            List<Players> m = sortedscore.ToList();
           
            if (m[0].GetScore() != m[1].GetScore())
            {
                var temp = (CardScores)m[0].GetScore()[0]; // A mess, has to be changed to produce proper text
                m[0].ChangeTokens(m.Count);
                return $"{m[0].Name} wins with {m[0].WinCard}";
            }
            else
            {
                return "Tie";
            }
        }
        public void PokerHandRankings(List<Players> l, List<Cards> Pokerhand)
        {
            List<Cards> ph = Pokerhand.ToList();
            foreach (string s in Hand)
            {
                ph.Add(new(s));
            }
            string hnd = String.Join(" ", Name, ph[0].Card, ph[1].Card, ph[2].Card, ph[3].Card, ph[4].Card, ph[5].Card, ph[6].Card);
            Console.WriteLine(hnd);
            List<int> faces = new();
            foreach (Cards f in ph)
            {
                faces.Add(f.PrintFace());
            }
            List<string> suits = new();

            foreach (Cards d in ph)
            {
                suits.Add(d.PrintSuit());
            }

            faces.Sort();
            int straight = 0;
            Cards card = Cards.ReturnCard(ph, faces.Max());
            WinCard = $"{card.PrintFullFace()} High";
            SetScore(new int[2] { 1, faces.Max() });

            for (int i = 0; i < 4; i++)  //  Checks if hand contains a straight
            {
                if (faces[i] + 1 == faces[i + 1])
                {
                    straight++;
                }
                if (straight == 4)
                {
                    WinCard = "a Straight";
                    SetScore(new int[2] { 5, 0 });
                    //CompareScore(l);
                }
            }

            int flush = 0;
            for (int i = 0; i < suits.Count; i++)  //  Checks if hand contains different varieties of a flush
            {
                if (suits[0] == suits[i])
                {
                    flush++;
                }
                if (flush == 5 && WinCard == "a Straight" && faces.Sum() == 60)
                {
                    WinCard = "a Royal Flush";
                    SetScore(new int[2] { 10, 0 });
                    //CompareScore(l);
                }
                else if (flush == 5 && WinCard == "a Straight")
                {
                    WinCard = "a Straight Flush";
                    SetScore(new int[2] { 9, 0 });
                    //CompareScore(l);
                }
                else if (flush == 5)
                {
                    WinCard = "a Flush";
                    SetScore(new int[2] { 6, 0});
                    //CompareScore(l);
                }
            }

            List<Cards> whand = new();
            for (int i = 0; i < faces.Count; i++)
            {
                List<int> mn = faces.ToList();
                mn.RemoveAt(i);

                for (int j = 0; j < mn.Count; j++)
                {
                    if (mn[j] == faces[i])
                    {
                        whand.Add(Cards.ReturnCard(ph, faces[j]));
                        break;
                    }
                }
            }
            if (whand.Count == 2)
            {
                WinCard = $"A Pair of {whand[0].PrintFullFacePl()}s";
                FullFace = whand[0].PrintFullFace();
                SetScore(new int[2] {2, whand[0].PrintFace() });
                //CompareScore(l);
            }
            else if (whand.Count == 3)
            {
                WinCard = $"Three of {whand[0].PrintFullFacePl()}s";
                FullFace = whand[0].PrintFullFace();
                SetScore(new int[2] { 4, whand[0].PrintFace() });
                //CompareScore(l);
            }
            else if (whand.Count == 4)
            {
                List<int> cd = Cards.ReturnCard(whand);
                cd.Sort();
                if (cd[0] == cd[3])
                {
                    WinCard = $"Four of {whand[0].PrintFullFacePl()}s";
                    FullFace = whand[0].PrintFullFace();
                    SetScore(new int[2] { 8, whand[0].PrintFace() });
                    //CompareScore(l);
                }
                else
                {
                    WinCard = "Two Pairs";
                    FullFace = whand[0].PrintFullFace();
                    SetScore(new int[2] { 3, whand[0].PrintFace() });
                    //CompareScore(l);
                }
            }
            else if (whand.Count == 5)
            {
                WinCard = "Full House";
                FullFace = whand[0].PrintFullFace();
                SetScore(new int[2] { 7, whand[0].PrintFace() });
                //CompareScore(l);
            }
           
        }
    }
}
// TODO:
// Figure out formatting for victory output
// Check whether the randomness of outcomes is random enough