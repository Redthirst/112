namespace AlienMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(spaceMessage("[3CD]"));

        }
        static string spaceMessage(string msg)
        {
            List<char> chars = msg.ToCharArray().ToList();
            char[] nums = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            string output = "";
            
            bool mode = false;
            
            while(chars.Count > 0)
            {
                string strNumber = "";
                int number = 0;
                string message = "";
                int counter = 0;
                List<char> temp = new List<char>();
                
                for (int i = 0; i < chars.Count; i++)
                {

                    if (chars[i] != '[' && mode == false)
                    {
                        output += String.Join("", chars[i]);
                        counter++;
                    }
                    else if (chars[i] == '[')
                    {
                        mode = true;
                        counter++;
                        continue;
                    }
                    if (mode == true && chars[i] != ']')
                    {
                        temp.Add(chars[i]);
                        counter++;
                    }
                    else if (mode == true && chars[i] == ']')
                    {
                        mode = false;
                        counter++;
                        break;
                    }
                }
                chars.RemoveRange(0, counter);
                for (int i = 0; i < temp.Count; i++)
                {
                    if (nums.Contains(temp[i]))
                    {
                        strNumber += String.Join("", temp[i]);
                        temp.RemoveAt(i);
                    }
                }

                message = String.Join("", temp);
                Int32.TryParse(strNumber, out number);
                for(int i = number; i > 0; i--)
                {
                    output += message;
                }
            }

            return output;
        }
    }
}