namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CaesarCipher("A friend in need is a friend indeed", 20));
        }
        static string CaesarCipher(string message, int n)
        {
            string[] str = message.Split(' ');

            List<List<char>> l = new();
            for(int i = 0; i < str.Length; i++)
            {
                l.Add(str[i].ToCharArray().ToList());
            }
            List<char> alphabet = new() { 'a', 'A', 'b', 'B', 'c' , 'C', 'd', 'D', 'e', 'E',
                'f', 'F', 'g', 'G', 'h', 'H', 'i', 'I', 'j', 'J', 'k', 'K', 'l', 'L', 'm', 'M', 'n', 'N', 
                'o', 'O', 'p', 'P', 'q', 'Q', 'r', 'R', 's', 'S', 't', 'T', 'u', 'U', 'v', 'V', 'w', 'W', 'x', 'X', 'y', 'Y', 'z', 'Z' };
   
            for (int i = 0; i < l.Count; i++)
            {
                for(int j = 0; j < l[i].Count; j++)
                {
                    if(alphabet.Contains(l[i][j]) == false)
                    {
                        continue;
                    }
                    int f = alphabet.IndexOf(l[i][j]) + (n * 2);
                    
                    if (f > alphabet.Count - 1)
                    {
                        int m = (alphabet.Count - 1) - alphabet.IndexOf(l[i][j]);
                        f = ((n * 2) - m) - 1;
                        
                    }

                    l[i][j] = alphabet[f];

                }
            }
            List<string> o = new();
            foreach(List<char> c in l)
            {
                o.Add(String.Join("", c));
            }
            string output = String.Join(' ', o);
            return output;
            
        }
    }
}