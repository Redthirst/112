namespace MaxDistance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxDistance("01"));
        }
        static int MaxDistance(string num)
        {
            List<int> li = new();
            List<char> ints = num.ToCharArray().ToList();

            int counter = 0;
            bool startswith = false;
            
            for(int i = 0; i < ints.Count; i++)
            {
                if (ints[0] == 1)
                {
                    startswith = true;
                }
                if(ints[i] == '0')
                {
                    counter++;
                    
                }
                else if (ints[i] == '1')
                {   if(startswith == true)
                    {
                        if(counter%2 > 0)
                        {
                            li.Add(counter / 2 + 1);
                        }
                        else
                        {
                            li.Add(counter / 2);
                        } 
                    }
                    else
                    {
                        li.Add(counter);
                        startswith = true;
                    }
                    counter = 0;
                }
                if(i == ints.Count - 1)
                {
                    li.Add(counter);
                }
            }
            return li.Max();
            
        }
    }
}