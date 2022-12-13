namespace ThreeSum_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string NicoCipher(string message, string key)
            {
                List<char> list = key.ToList();  //  list for all leters in a key, sorted
                List<char> olist = key.ToList(); //  same, but unsorted
                List<char> mlist = message.ToList(); //  list of all letters in a message

                List<int> keylist = new();  //  list of numbers assigned to key
                List<string> li = new();  //  list for results of the first conversion  
                List<string> nl = new();  //  list for results of the second conversion


                list.Sort();
                int s = 1;
                IDictionary<int, char> dict = new Dictionary<int, char>();  
                IDictionary<int, string> dict2 = new Dictionary<int, string>();

                char d;

                foreach(char c in list)  //  Assigns a number to each letter in a key
                {
                    dict.Add(s, c);
                    s++;

                }
                
                foreach(char c in olist) //  Puts all assigned numbers in the original order
                {
                    for(int i = 1; i < olist.Count + 1; i++)
                    {
                        char a;
                        dict.TryGetValue(i, out a);
                        if(a == c)
                        {
                            keylist.Add(i);
                            Console.WriteLine(i);
                            break;
                        }
                    }
                    

                }

                for(int i = 0; i < keylist.Count; i++)  // Assigns numbers from key to the message
                {
                    try
                    {
                        d = mlist[i + keylist.Count * 2];
                        string f = String.Join("", mlist[i], mlist[i + keylist.Count], d);
                        dict2.Add(keylist[i], f);
                    }
                    catch
                    {
                        d = ' ';
                        string f = String.Join("", mlist[i], mlist[i + keylist.Count], d);
                        dict2.Add(keylist[i], f);
                    }
                    
                }

                keylist.Sort();

                foreach (int m in keylist)  // Rearranges the message based on numbers
                {
                    string ft;
                    dict2.TryGetValue(m, out ft);
                    li.Add(ft);
                }
                
                int rl = 0;
                int sf = 0;
                char[] pl = new char[li.Count];

                for (int i = 0; i < message.Length; i++)  // Encodes the rearranged message
                {
                    pl[rl] = li[rl][sf];
                    rl++;

                    if (rl == li.Count)
                    {
                        string f = String.Join("", pl);
                        nl.Add(f);
                        rl = 0;
                        sf++;
                        Console.WriteLine(f);
                    }
                    if (i == message.Length - 1)
                    {
                        string f = String.Join("", pl);
                        nl.Add(f);
                    }
                }


                string output = String.Join("", nl);

                return output;
            }
            Console.WriteLine(NicoCipher("iloveher", "612345"));
        }
    }
}