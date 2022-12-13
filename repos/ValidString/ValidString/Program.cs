namespace ValidString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isValid("abcdefghhgfedecba"));
        }
        static string isValid(string inp)
        {
            char[] chars = inp.ToCharArray();
            List<char> op = chars.ToArray().ToList();
            List<char> c = new();
            int counter = 0;

            do
            {
                c = op.Distinct().ToList();
                counter++;
                foreach (char c2 in c)
                {
                    op.Remove(c2);
                }

            }
            while (op.Count > chars.Length / 2);
            
            if (chars.Length > (c.Count * counter) + 1)
            {
                return "No";
            }
            else return "Yes";
        }
    }
}