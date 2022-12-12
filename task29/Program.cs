﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] CreateRandArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        Console.WriteLine($"Ввведите {i+1} элемент массива:");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}
void PrintRandArray(int[] arr)
{
    Console.Write("\nПолученный массив: ");
    Console.Write("[");
    for (int i = 0; i < 7; i++) Console.Write(arr[i] + ",");
    Console.Write(arr[7] + "]");
}
PrintRandArray(CreateRandArray());
