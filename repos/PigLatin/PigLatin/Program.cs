namespace PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string TranslateWord(string word)
            {
                char[] cons = new char[21] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
                List<char> list = new List<char>();
                string newword = "l";
                for (int i = 0; i < word.Length; i++)
                {
                    if (cons.Contains(word[0]) == false)
                    {
                        newword = String.Join("", word, "yay");
                    }
                    else if (cons.Contains(word[i]))
                    {
                        list.Add(word[i]);
                        newword = word.Substring(i + 1);
                    }
                    else
                    {
                        string temp = String.Join("", list);
                        newword = String.Join("", newword, temp, "ay");
                        break;
                    }
                }
                if (word == "")
                {
                    return "";
                }
                else
                {
                    return newword;
                }
            }
            
            string TranslateSentence(string sentence)
            {
                char[] cons = new char[21] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
                string[] words = sentence.Split(' ');

                words[words.Length - 1] = words[words.Length - 1].Remove(words[words.Length - 1].Length - 1, 1);
                words[0] = words[0].ToLower();

                List<string> sent = new();
                List<char> list = new();
               
                string newword = "s";

                for (int i = 0; i < words.Length; i++)
                {
                    for(int j = 0; j < words[i].Length; j++)
                    {
                        if (cons.Contains(words[i][0]) == false)
                        {
                            sent.Add(String.Join("", words[i], "yay"));
                            break;
                        }
                        else if (cons.Contains(words[i][j]))
                        {
                            list.Add(words[i][j]);
                            newword = words[i].Substring(j + 1);
                        }
                        else
                        {
                            string temp = String.Join("", list);
                            sent.Add(String.Join("", newword, temp, "ay"));;
                            list.Clear();
                            break;
                        }
                    }
                    
                }
                char[] letters = sent[0].ToCharArray();
                letters[0] = char.ToUpper(letters[0]);
                string caplet = new string(letters);

                sent[0] = sent[0].Replace(sent[0], caplet);
                string newsent = String.Join(' ', sent);
                newsent = String.Join("", newsent, '.');
                if(sentence == "")
                {
                    return "";
                }
                else
                {
                    return newsent;
                }
            }
            Console.WriteLine(TranslateWord("cat"));
            Console.WriteLine(TranslateWord("Apple"));
            Console.WriteLine(TranslateWord("button"));
            Console.WriteLine(TranslateWord(""));
            Console.WriteLine(TranslateSentence("I like to eat honey waffles."));
            Console.WriteLine(TranslateSentence("Do you think it is going to rain today?"));
        } 
    }
}