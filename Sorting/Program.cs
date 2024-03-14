﻿// declare an array of integers that are not sorted

int[] numbers = { 5, 4, 1, 3, 2 };

// sort the array and display the result with proper comments


Array.Sort(numbers);
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// declare an array of strings that are not sorted
Console.WriteLine();

string[] names = { "Alfa", "Charlie", "Bravo", "Echo", "Delta" };

// sort the array without using array.sort and display the result with proper comments
for (int i = 0; i < names.Length; i++)
{
    for (int j = i + 1; j < names.Length; j++)
    {
        if (names[i].CompareTo(names[j]) > 0)
        {
            string temp = names[i];
            names[i] = names[j];
            names[j] = temp;
        }
    }
}

Console.WriteLine();
foreach (string name in names)
{
    Console.WriteLine(name);
}

