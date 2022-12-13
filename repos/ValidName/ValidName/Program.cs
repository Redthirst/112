namespace ValidName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool ValidName(string name)
            {
                List<char> alphabet = new() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
                string[] nm = name.Split(' ');

                bool firstname = false;
                bool middlename = false;
                bool lastname = false;

                if(nm.Length < 2 || nm.Length > 3)
                {
                    return false;
                }

                if (nm[0].Length < 2 || alphabet.Contains(nm[0][0]) == false)
                {
                    return false;
                }
                else if (nm[0].Length > 1 && alphabet.Contains(nm[0][0]))
                {
                    if (nm[0].Length > 2 && nm[0].Contains('.'))
                    {
                        return false;
                    }
                    else
                    {
                        firstname = true;
                    }
                }

                if(nm.Length == 3)
                {
                    if (nm[1].Length < 2 || alphabet.Contains(nm[1][0]) == false)
                    {
                        return false;
                    }
                    else if (nm[1].Length > 2 && nm[0].Contains('.'))
                    {
                        return false;
                    }
                    else if (nm[0].Length < 3 && nm[1].Length > 2)
                    {
                        return false;
                    }
                    else
                    {
                        middlename = true;
                    }
                }

                if(nm.Length == 2)
                {
                    if (nm[1].Length < 2 || alphabet.Contains(nm[1][0]) == false || nm[1].Contains('.'))
                    {
                        return false;
                    }
                    else
                    {
                        lastname = true;
                    }
                }
                else if(nm.Length == 3)
                {
                    if (nm[2].Length < 2 || alphabet.Contains(nm[2][0]) == false || nm[2].Contains('.'))
                    {
                        return false;
                    }
                    else
                    {
                        lastname = true;
                    }
                }

                if (nm.Length == 2)
                {
                    if (firstname && lastname == true)
                    {
                        return true;
                    }
                    else return false;
                }
                else if (nm.Length == 3)
                {
                    if (firstname && middlename && lastname == true)
                    {
                        return true;
                    }
                    else return false;
                }
                else return false;

            }
            Console.WriteLine(ValidName("Al Jean"));
        }
    }
}