using System.Collections.Generic;
namespace ConsoleApp4
{
    class Program
    {

        public static void Main()
        {
            bool PalindromeDescendant(int num)
            {
                string snum = Convert.ToString(num);
                string[] li = new string[snum.Length];
                int[] inli = new int[snum.Length / 2];
                List<int> clist = new();
                int m = 0;
                bool active = true;
                int cnum = 0;
                int rcnum = 0;
                
                for(int i = 0; i < snum.Length; i++)  //  Creates array of characters, string type
                {
                    li[i] = snum[i].ToString();
                }
                int[] nli = new int[li.Length];
                
                for(int i =0; i < li.Length; i++)  //  Converts strings to int
                {
                    Int32.TryParse(li[i], out nli[i]);
                }
                List<int> nlist = nli.ToList();

                while (active)
                {
                    for (int i = 0; i != nlist.Count / 2; i++)
                    {
                        clist.Add(nlist[m] + nlist[m + 1]);
                        m += 2;
                    }
                    var childnum = String.Join("", clist);
                    clist.Reverse();
                    var revcnum = String.Join("", clist);
                    if(clist.Count == 2 || childnum == revcnum)
                    {
                        Int32.TryParse(childnum, out cnum);
                        Int32.TryParse(revcnum, out rcnum);
                        active = false;
                    }
                    else
                    {
                        clist.Reverse();
                        nlist.Clear();
                        nlist.AddRange(clist);
                        clist.Clear();
                        m = 0;
                    }
                }

                Array.Reverse(li);
                var rnum = String.Join("", li);

                int newnum;
                Int32.TryParse(rnum, out newnum);


                if (num == newnum || cnum == rcnum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            Console.WriteLine(PalindromeDescendant(11));
        }
    }
    
}