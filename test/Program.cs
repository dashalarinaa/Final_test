﻿// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


Console.Write("Введите элементы(через пробел): ");
string[] array = (Console.ReadLine().Split());
Console.Write("Первоначальный массив: ");
 for (int i = 0; i < array.Length; i++)
 {
    Console.Write(" " + array[i]);
 }
Console.WriteLine();

string[] array2 = new string[array.Length];

    int count = 0;
    Console.Write("Полученный массив: ");
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        Console.Write(" " + array[i]);
        }
    }