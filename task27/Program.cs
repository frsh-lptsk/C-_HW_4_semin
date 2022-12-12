// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Write("Введите любое число : ");
int A = int.Parse(Console.ReadLine()!);

int CountSumofChar(int number)
{
    int average = 0;
    int result = 0;
    for (int i = 0; i <= number; i++)
    {
        average = number - number % 10;
        result = result + (number - average);
        number = number / 10;
    }
    return result;
}

Console.WriteLine($"Сумма цифр в числе = {CountSumofChar(A)}");