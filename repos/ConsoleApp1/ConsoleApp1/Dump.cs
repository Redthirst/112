var list = new List<int> { 1, 4, 7 };

void Index(int number)
{
    int num1 = list.IndexOf(number);
    if (num1 == -1)
    {
        Console.WriteLine($"{number} is not found in the list");
    }
    else
    {
        Console.WriteLine($"{number} is found at {num1}");
    }
}

//Index(8);

var Fibonacci = new List<int> { 1, 1 };


for (int item = 0; item < 18; item++)
{
    var previous1 = Fibonacci[Fibonacci.Count - 1];
    var previous2 = Fibonacci[Fibonacci.Count - 2];
    Fibonacci.Add(previous1 + previous2);
}

Console.WriteLine(Fibonacci.Count);

//foreach (var item in Fibonacci)
//    Console.WriteLine(item);


