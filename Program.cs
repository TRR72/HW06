/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях (индексах).

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
Console.Write("Введите числа массива(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int OddIndexSum(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int oddSum = OddIndexSum(arr);
Console.WriteLine(oddSum);
*/
/* 
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/* 
var array = new decimal[5];
for (int i = 0; i < 5; i++)
{
    Console.Write("Введите пять чисел из массива {0} число : ", i + 1);
    array[i] = Convert.ToDecimal(Console.ReadLine());
}

var max = array[0];
var min = array[0];
for (int i = 1; i < 5; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}

Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);
*/
/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  
*/
int size = ReadInt("Введите размерность массива: ");
int [] numbers = new int[size];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        result++;
    }
}
if (result % 10 == 1)
{
    Console.WriteLine($"В массиве {result} четное число");
}
if (result % 10 == 2 || result % 10 == 3 || result % 10 == 4)
{
    Console.WriteLine($"В массиве {result} четных числа");
}

void FillArrayRandomNumbers(int [] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 999);
    }
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)  
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
