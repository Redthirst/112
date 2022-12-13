using System;
using System.Collections.Generic;

//int Divisible(int value1, int value2)
//{
//    if (value1 % 2 == 0 || value1 % 3 == 0 && value2 % 2 == 0 || value2 % 3 == 0)
//    {
//        return value1 * value2;
//    }
//    else
//    {
//        return value1 + value2;
//    }
//}

//Console.WriteLine(Divisible(10, 6));

//bool Uppercase(string b)
//{
//    string c =  b.ToUpper();
//    if (c == b)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(Uppercase("XYZ"));

//bool GreaterThan(int a1, int a2, int a3)
//{
//    int[] array1 = new int[3] { a1, a2, a3 };
//    if (array1[0] + array1[1] > array1[2] || array1[0] * array1[1] > array1[2])
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(GreaterThan(2, 7, 12));

//bool Ascendency(int[] arr)
//{
//    if (arr[2] > arr[1] && arr[1] > arr[0])
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(Ascendency(new int[]{15, 7, 10}));

//int i = 1234;
////int a = i / 100;
////int b = i % 10;
////int v = 2212;
//int[] arr = new int[] {1, 2};
////Console.WriteLine($"{a} and {b}");

//int x = 4;
//int d = 1000;

//int a = 0;
//int b = 0;
//int c = 0;
//int f = 0;
//int p = 0;
//int o = 0;
//int l = 0;
//int m = 0;

bool ContainsThree(int i)
{
    while (i > 0)
    {
        int a = i % 10;
        i /= 10;
        if (a == 3)
        {
            return true;
        }
    }
    return false;
   

}
Console.WriteLine(ContainsThree(87501));

//while (x > 0)
//{   
//    if (a == 0)
//    {
//        a = i / d;
//        --x;
//        d *= 10;
//        Console.WriteLine(x);
//    }
//    else
//    {
//        continue;
//    }
//    if (b == 0)
//    {
//        b = i / d;
//        --x;
//        d *= 10;
//        Console.WriteLine(x);
//    }
//    else
//    {
//        continue;
//    }
//    if (c == 0)
//    {
//        c = i / d;
//        --x;
//        d *= 10;
//        Console.WriteLine(x);
//    }
//    else
//    {
//        continue;
//    }
//    if (f == 0)
//    {
//        f = i / d;
//        --x;
//        d *= 10;
//        Console.WriteLine(x);
//    }
//    else
//    {
//        continue;
//    }
//    if (p == 0)
//    {
//        p = i / d;
//        --x;
//        d *= 10;
//    }
//    else
//    {
//        continue;
//    }
//    if (o == 0)
//    {
//        o = i / d;
//        --x;
//        d *= 10;
//    }
//    else
//    {
//        continue;
//    }
//    if (l == 0)
//    {
//        l = i / d;
//        --x;
//        d *= 10;
//    }
//    else
//    {
//        continue;
//    }
//    if (m == 0)
//    {
//        m = i / d;
//        --x;
//        d *= 10;
//    }
//    else
//    {
//        continue;
//    }

//}
//Console.WriteLine($"{a}, {b}, {c}, {f}, {p}, {o}, {l}, {m}");
