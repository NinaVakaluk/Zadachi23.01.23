/*Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, а также возвращает сообщение о том, что оно 
найдено или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4
17 -> такого числа в массиве нет*/

Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(10, 30);
if (GetArray2(N, array))
{ Console.WriteLine($"Число {N} есть в массиве"); }
else
{ Console.WriteLine($"Число {N} отсутствует в массиве"); }


int[,] GetArray(int minValue, int maxValue)
{
    int[,] result = new int[3, 4];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
            Console.Write($" {result[i, j]} ");
        }
        Console.WriteLine();
    }
    return result;
}

bool GetArray2(int N, int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == N) return true;

        }
    }
    return false;
}