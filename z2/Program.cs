/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int [] CreateNewArray (int size, int minVal, int maxVal)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        array [i] = new Random().Next(minVal, maxVal + 1);
    }
    return array;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int FindSumNeChetI (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array [i];
        }
    }
    return sum;
}

Console.Write ("Input count of elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input minimal possible value of elements: ");
int minValue = Convert.ToInt32(Console.ReadLine());

Console.Write ("Input maximal possible value of elements: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [] newArray = CreateNewArray (sizeArray, minValue, maxValue);
ShowArray (newArray);

Console.Write ($"Sum of elements in odd positions is {FindSumNeChetI (newArray)}");