namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ar = { 4, 3, 2, 1, 3, 2, 1, 1 };
            Countdown(ar);
        }
        static void Countdown(int[] array)
        {
            List<List<int>> list = new List<List<int>>();
            List<int> ints = new();
            int m = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 1)
                {
                    ints.Add(array[i]);
                    list.Add(ints.ToList());
                    ints.Clear();
                    
                }
                else if (array[i] + 1 == m || array[i] - 1 == array[i + 1])
                {
                    ints.Add(array[i]);
                    if (array[i] == 1)
                    {
                        list.Add(ints.ToList());
                        ints.Clear();
 
                    }
                    m = array[i];
                }
                else
                {

                    m = array[i];
                    continue;
                }


            }
            int counter = list.Count;

            int[][] s = new int[list.Count][];
            for(int i = 0; i < list.Count; i++)
            {
                s[i] = list[i].ToArray();
            }
            Console.WriteLine(counter);

            for(int i = 0; i < s.Length; i++)
            {
                for(int j = 0; j < s[i].Length; j++)
                {
                    Console.Write($"{s[i][j]} ");
                }
                Console.Write("||");
            }

            

        }
    }
}