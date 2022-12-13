#include "pch.h"
#include <iostream>

using namespace winrt;
using namespace Windows::Foundation;
using namespace std;

int main()
{
    int cf = 12;
    int mt = cf + 10;
    string lt;
    string ar[4]{ "Hello", "World", "Yes", "No" };
    int count = *(&ar + 1) - ar;
    for (int i = 0; i < count; i++)
    {
        while (ar[i] != "No")
        {
            cout << ar[i] + "\n";
            break;
        }
    }

    

    return 0;
}
