namespace FiscalCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            People m = new("Mat", "Mouse", "M", "16/1/1928");
            Console.WriteLine(m.FiscalCode());
        }
    }
    public class People
    {
       public enum Months
        {
            A = 1,
            B = 2,
            C = 3,
            D = 4,
            E = 5,
            H = 6,
            L = 7,
            M = 8,
            P = 9,
            R = 10,
            S = 11,
            T = 12
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public string DOB { get; set; }
        public People(string name, string surname, string gender, string dOB)
        {
            Name = name.ToLower();
            Surname = surname.ToLower();
            Gender = gender;
            DOB = dOB;
        }
        public string FiscalCode()
        {
            char[] cons = new char[21] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            char[] vowl = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            char[] srn = Surname.ToCharArray();
            string surcap = "";

            List<char> sclist = new();
            List<char> svlist = new();

            foreach(char s in srn)
            {
                if (cons.Contains(s))
                {
                    sclist.Add(s);
                }
                else if (vowl.Contains(s))
                {
                    svlist.Add(s);
                }
            }
            
            if(sclist.Count >= 3)
            {
                surcap = String.Join("", sclist[0], sclist[1], sclist[2]);
            }
            else if (Surname.Length < 3)
            {
                surcap = String.Join("", sclist[0], svlist[0], "X");
            }
            else if(sclist.Count < 3)
            {
                if(sclist.Count == 2)
                {
                    surcap = String.Join("", sclist[0], sclist[1], svlist[0]);
                }
                else if(sclist.Count == 1 && Surname.Length > 2)
                {
                    surcap = String.Join("", sclist[0], svlist[0], svlist[1]);
                }
            }
            

            char[] nm = Name.ToCharArray();
            string namecap = "";
            
            List<char> nclist = new();
            List<char> nvlist = new();

            foreach(char c in nm)
            {
                if (cons.Contains(c))
                {
                    nclist.Add(c);
                }
                else if (vowl.Contains(c))
                {
                    nvlist.Add(c);
                }
            }

            if(nclist.Count == 3)
            {
                namecap = String.Join("", nclist[0], nclist[1], nclist[2]);
            }
            else if(nclist.Count > 3)
            {
                namecap = String.Join("", nclist[0], nclist[2], nclist[3]);
            }
            else if (Name.Length < 3)
            {
                namecap = String.Join("", nclist[0], nvlist[0], "X");
            }
            else if(nclist.Count < 3)
            {
                if (nclist.Count == 2)
                {
                    namecap = String.Join("", nclist[0], nclist[1], nvlist[0]);
                }
                else if (nclist.Count == 1 && Name.Length > 2)
                {
                    namecap = String.Join("", nclist[0], nvlist[0], nvlist[1]);
                }
            }
            

            string[] dob = DOB.Split('/');

            string yn = String.Join("", dob[2][2], dob[2][3]); 
            
            Enum.TryParse<Months>(dob[1], out Months mne);
            string mn = Enum.GetName<Months>(mne);

            string dn = "";
            int day;
            Int32.TryParse(dob[0], out day);
            if (Gender == "M")
            {
                if(day < 10)
                {
                    dn = String.Join("", "0", day.ToString());
                }
                else if(day > 10)
                {
                    dn = day.ToString();
                }
            }
            else if(Gender == "F")
            {
                day += 40;
                dn = day.ToString();
            }

            string output = String.Join("", surcap, namecap, yn, mn, dn);
            output = output.ToUpper();
            return output;
        }
    }
}