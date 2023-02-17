/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int FindSumChet (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum += 1;
        }
    }
    return sum;
}

Console.Write ("Input count of elements: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int minPosVal = 100;
int maxPosVal = 999;

int [] newArray = CreateNewArray (sizeArray, minPosVal, maxPosVal);
ShowArray (newArray);

Console.Write ($"Sum of even elements is {FindSumChet (newArray)}");