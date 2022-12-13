namespace Password_encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string SecretPassword(string message)
            {
                List<char> alphabet = new() {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
                char[] mes = message.ToCharArray();
                bool validation = false;
                foreach(char c in mes)
                {
                    if(alphabet.Contains(c) == false)
                    {
                        validation = true;
                        break;
                    }
                }
                
                if(message.Length != 9 || validation == true)
                {
                    return "Bang-Bang-Bang";
                }
                
                char[] p1 = new char[3] { mes[0], mes[1], mes[2] };
                char[] p2 = new char[3] { mes[3], mes[4], mes[5] };
                char[] p3 = new char[3] { mes[6], mes[7], mes[8] };
                string[] pr1 = new string[3];


                pr1[0] = (alphabet.IndexOf(p1[0]) + 1).ToString();
                pr1[2] = (alphabet.IndexOf(p1[2]) + 1).ToString();
                pr1[1] = p1[1].ToString();
                string part1 = String.Join("", pr1);

                p2 = p2.Reverse().ToArray();
                string part2 = String.Join("", p2);

                for (int i = 0; i < p3.Length; i++)
                {
                    if (p3[i] == 'z')
                    {
                        p3[i] = 'a';
                    }
                    else
                    {
                        p3[i] = alphabet[alphabet.IndexOf(p3[i]) + 1];
                    }
                }
                string part3 = String.Join("", p3);

                string output = String.Join("", part2, part3, part1);
                return output;
            }   
            Console.WriteLine(SecretPassword("HeLen-eda"));
        }
       
    }
       
    
}


