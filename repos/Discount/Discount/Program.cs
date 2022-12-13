namespace Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Discount(20, "10, 10%"));
        }
        public static int Discount(int amount, string discount)
        {
            List<string> list = new List<string>();
            List<int> discounts = new List<int>();
            list = discount.Split(',').ToList();
            
            foreach(string item in list)
            {               
                int disc = 0;
                if (item.Contains('%'))
                {
                    Int32.TryParse(item.Remove(item.Length - 1), out disc);
                    amount -= (amount * disc / 100);
                }
                else
                {
                    Int32.TryParse(item, out disc);
                    discounts.Add(disc);
                }
            }

            foreach(int num in discounts)
            {
                amount -= num;
            }

            return amount;
        }
    }
}