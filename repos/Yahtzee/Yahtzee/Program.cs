namespace Yahtzee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aces = new int[] { 1, 3, 1, 1, 2 };
            int[] twos = new int[] { 1, 2, 4, 5, 6 };
            int[] threes = new int[] { 6, 3, 4, 3, 4 };
            int[] fours = new int[] { 3, 1, 1, 4, 4 };
            int[] fives = new int[] { 5, 5, 5, 5, 3 };
            int[] sixes = new int[] { 6, 2, 6, 6, 6 };
            int[] toak = new int[] { 1, 4, 4, 2, 1 };
            int[] foak = new int[] { 3, 3, 3, 3, 3 };
            int[] fh = new int[] { 2, 2, 1, 1, 2 };
            int[] ls = new int[] { 6, 1, 2, 3, 4 };
            int[] hs = new int[] { 2, 3, 5, 4, 1 };
            int[] yht = new int[] { 4, 4, 4, 4, 4 };
            int[] chance = new int[] { 3, 3, 4, 5, 6 };

            int[][] yahtzee = new int[][] {aces, twos, threes, fours, fives, sixes, toak, foak, fh, ls, hs, yht, chance};

            Console.WriteLine(YahtzeeScoreCalc(yahtzee));

        }
        static void test(int[][] arr)
        {
            List<int> tmp = new();
            tmp = arr[6].ToList();
            Console.WriteLine(tmp.Count);
        }
        static int YahtzeeScoreCalc(int[][] arr)
        {
            int score = 0;
            foreach(int i in arr[0])
            {
                if(i == 1)
                {
                    score++;
                }
            }
            Console.WriteLine($"{1} {score}");
            foreach (int i in arr[1])
            {
                if (i == 2)
                {
                    score += 2;
                }
            }
            Console.WriteLine($"{2} {score}");
            foreach (int i in arr[2])
            {
                if (i == 3)
                {
                    score += 3;
                }
            }
            Console.WriteLine($"{3} {score}");
            foreach (int i in arr[3])
            {
                if (i == 4)
                {
                    score += 4;
                }
            }
            Console.WriteLine($"{4} {score}");
            foreach (int i in arr[4])
            {
                if (i == 5)
                {
                    score += 5;
                }
            }
            Console.WriteLine($"{5} {score}");
            foreach (int i in arr[5])
            {
                if (i == 6)
                {
                    score += 6;
                }
            }
            Console.WriteLine($"{6} {score}");
            if (score >= 63)
            {
                score += 35;
                Console.WriteLine($"{"Bonus"} {score}");
            }
            
            List<int> com = new();
            List<int> tmp = new();

            
            for(int i = 0; i < arr[6].Length; i++)
            {
                tmp = arr[6].ToList();
                tmp.RemoveAt(i);
                for(int j = 0; j < tmp.Count; j++)
                {
                    if (tmp[j] == arr[6][i])
                    {
                        com.Add(tmp[j]);
                        break;
                    }
                }
            }
            com.Sort();
            if(com.Count >= 3 && com[0] == com.Last())
            {
                score += arr[6].Sum();
                Console.WriteLine($"{7} {score}");
            }
            
            com.Clear();
            
            for (int i = 0; i < arr[7].Length; i++)
            {
                tmp = arr[7].ToList();
                tmp.RemoveAt(i);
                for (int j = 0; j < tmp.Count; j++)
                {
                    if (tmp[j] == arr[7][i])
                    {
                        com.Add(tmp[j]);
                        break;
                    }
                }
            }
            if (com.Count >= 4 && com[0] == com.Last())
            {
                score += arr[7].Sum();
                Console.WriteLine($"{8} {score}");
            }
            
            com.Clear();
            tmp = arr[8].ToList();
            for (int i = 0; i < arr[8].Length; i++)
            {
                tmp = arr[8].ToList();
                tmp.RemoveAt(i);
                for (int j = 0; j < tmp.Count; j++)
                {
                    if (tmp[j] == arr[8][i])
                    {
                        com.Add(tmp[j]);
                        break;
                    }
                }
            }
            com.Sort();
            if (com.Count >= 5 && com[0] != com.Last())
            {
                score += 25;
                Console.WriteLine($"{9} {score}");
            }

            com.Clear();
            tmp = arr[9].ToList();
            
            tmp.Sort();
            int count = 0;
            for (int i = 0; i < 4; i++)
            {
                if (tmp[i] == tmp[i + 1] - 1 || tmp[i] == tmp[i - 1] + 1)
                {
                    count++;
                    com.Add(tmp[i]);
                }
            }
            if (com.Count >= 4)
            {
                score += 30;
                Console.WriteLine($"{10} {score}");
            }

            com.Clear();
            tmp = arr[10].ToList();

            tmp.Sort();
            for (int i = 0; i < 4; i++)
            {
                if (tmp[i] == tmp[i + 1] - 1 || tmp[i] == tmp[i - 1] + 1)
                {
                    com.Add(tmp[i]);
                    if(i == 3)
                    {
                        com.Add(tmp[4]);
                    }
                }
            }
            if (com.Count == 5)
            {
                score += 40;
                Console.WriteLine($"{11} {score}");
            }

            com.Clear();
            tmp = arr[11].ToList();

            int t = tmp[0];
            for(int i = 0; i < tmp.Count; i++)
            {
                if(tmp[i] == t)
                {
                    com.Add(tmp[i]);
                }
            }
            if (com.Count == 5)
            {
                score += 50;
                Console.WriteLine($"{12} {score}");
            }

            score += arr[12].Sum();
            Console.WriteLine($"{13} {score}");

            return score;
        }
    }
}