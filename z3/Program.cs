/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. 
Math.Min и Math.Max не использовать.
[3.0 7.1 22.5 2.7 78.8] -> 76.1
*/

void CreateNewArray (double [] array)
{
        for (int i = 0; i < array.Length; i++)
    {
        array [i] = Convert.ToDouble (new Random().Next(100, 1000)) / 100;
    }
}

void ShowArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double [] array = new double [size];

CreateNewArray(array);
ShowArray(array);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < array.Length; z++)
{
    if (array[z] > max)
        {
            max = array[z];
        }
    if (array[z] < min)
        {
            min = array[z];
        }
}

Console.WriteLine($"Всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");