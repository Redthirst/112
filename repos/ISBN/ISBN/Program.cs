namespace ISBN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ISBN13("0330301824"));
        }
        static string ISBN13(string num)
        {
            int[] tn = new int[10] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, };
            int[] thtn = new int[13] { 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1, 3, 1 };
            int[] isbn10 = new int[10];
            int[] op = new int[10];
            int[] isbn13 = new int[13];
            char[] ch = num.ToCharArray();
            string output = "";

            if(ch.Length == 10)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    isbn10[i] = (int)char.GetNumericValue(ch[i]);
                    
                }
                op = isbn10.ToArray();
                for (int i = 0; i < isbn10.Length; i++)
                { 
                    isbn10[i] *= tn[i];
                }
                if (isbn10.Sum() % 11 == 0)
                {
                    List<int> li = op.ToList();
                    List<int> newli = new() { 9, 7, 8 };
                    li.InsertRange(0, newli);
                   
                    for(int i = 0; i < 10; i++)
                    {
                        List<int> nli = li.ToList();
                        
                        nli.Remove(nli[12]);
                        nli.Insert(12, i);
                        newli = nli.ToList();
                        
                        for (int j = 0; j < nli.Count; j++)
                        {
                            nli[j] *= thtn[j];
                        }
                        if (nli.Sum() % 10 == 0)
                        {
                            output = String.Join("", newli);
                            break;
                        }
                    }
                    
                   
                }
                else
                {
                    output = "Invalid";
                }
            }
            else if(ch.Length == 13)
            {
                for (int i = 0; i < ch.Length; i++)
                {
                    isbn13[i] = (int)char.GetNumericValue(ch[i]);
                }
                for (int i = 0; i < isbn13.Length; i++)
                {
                    isbn13[i] *= thtn[i];
                }
                if(isbn13.Sum()%10 == 0)
                {
                    output = "Valid";
                }
                else
                {
                    output = "Invalid";
                }
            }
            else
            {
                output = "Invalid";
            }
            return output;
        }
    }
}