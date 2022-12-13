namespace StringCleaver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringCleaver("ifitistobeitisuptome"));
            
        }
        static string StringCleaver(string inp)
        {
            string[] words = new string[] { "about", "be", "hell", "if", "is", "it", "me", "other", "outer", "people", "the", "to", "up", "where" };
            char[] chars = inp.ToCharArray();
            List<char> list = chars.ToList();
            List<string> strings = new List<string>();

            for(int i = 0; i < list.Count; i++)
            {
                string lm = String.Join("", list[i]);

                for(int j = i + 1; j < list.Count; j++)
                {
                    lm = String.Join("", lm, list[j]);
                    if (words.Contains(lm))
                    {
                        
                        strings.Add(lm);
                        list.RemoveRange(i, j - i + 1);
                        i = -1;
                        break;
                    }
                    
                }
                
            }
            string output = "";
            if(list.Count > 0)
            {
                output = "Cleaving stalled: Word not found";
            }
            else
            {
                output = String.Join(' ', strings);
            }
            return output;
        }
    }
}