namespace Syllables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sylab("lAjevard"));
        }
        static string Sylab(string input)
        {
            char[] vowels = new char[6] { 'a', 'A', 'e', 'i', 'o', 'u' };
            char[] word = input.ToCharArray();
            string output = "";
            List<int> index = new List<int>();

            if (vowels.Contains(word[0]) == true || vowels.Contains(word[1]) == false)
            {
                output = "Not a valid word";
                return output;
            }

            for(int i = 0; i < word.Length; i++)
            {
                if (vowels.Contains(word[i]) == true)
                {
                    index.Add(i);
                }
            }

            if(index.Count == 1)
            {
                output = String.Join("", word);
                return output;
            }
            output = String.Join("", word[0]);
            for(int i = 0; i < index.Count; i++)
            {
                if(i != index.Count - 1)
                {
                    int diff = index[i + 1] - index[i];
                    switch (diff)
                    {
                        case 2: output += String.Join("", word[index[i]], '.', word[index[i] + 1]);
                            Console.WriteLine($"{diff} and {output}");
                            break;
                        case 3: output += String.Join("", word[index[i]], word[index[i] + 1], '.', word[index[i] + 2]);
                            Console.WriteLine($"{diff} and {output}");
                            break;
                        case 4: output += String.Join("", word[index[i]], word[index[i] + 1], word[index[i] + 2], '.', word[index[i] + 3]);
                            Console.WriteLine($"{diff} and {output}");
                            break;
                    }
                        
                }
                else
                {
                    for(int s = index[i]; s < word.Length; s++)
                    {
                        output += String.Join("", word[s]);
                    }
                }
            }
            return output;
        }
    }
}