namespace MaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long[] Maxmin(long num)
            {
                char[] temp = num.ToString().ToCharArray();
                List<double> tli = new();
                
                foreach(char c in temp)
                {
                    double a = Char.GetNumericValue(c);
                    tli.Add(a);
                }

                List<double> mli = new(tli);
                int f = tli.IndexOf(tli.Max());
                double m = tli[0];
                
                tli.Insert(0, tli.Max());
                tli.RemoveAt(1);
                tli.RemoveAt(f);
                tli.Insert(f, m);

                string fs = String.Join("", tli);
                long maxie = long.Parse(fs);

                int s = mli.IndexOf(mli.Min());
                int s2 = 0;

                double fm = mli.Min();
                double fm2 = 0;
                if(fm == 0)
                {
                    mli.RemoveAt(s);
                    fm2 = mli.Min();
                    s2 = mli.IndexOf(mli.Min());
                    mli.Insert(s, fm);

                    if(fm2 != mli[0])
                    {
                        double st = mli[0];
                        mli.Insert(0, fm2);
                        mli.RemoveAt(1);
                        mli.RemoveAt(s2);
                        mli.Insert(s2, st);
                    }
                    else
                    {
                        double st = mli[1];
                        mli.Insert(1, fm);
                        mli.RemoveAt(2);
                        mli.RemoveAt(s);
                        mli.Insert(s, st);
                    }
                    
                }
                else
                {
                    double st = mli[0];
                    mli.Insert(0, fm);
                    mli.RemoveAt(1);
                    mli.RemoveAt(s);
                    mli.Insert(s, st);
                }
                string ps = String.Join("", mli);
                long minnie = long.Parse(ps);
                long[] output = new long[2] { maxie, minnie };
                return output;
            }

            Console.WriteLine(Maxmin(11321)[0]);
            Console.WriteLine(Maxmin(11321)[1]);
        }
    }
}