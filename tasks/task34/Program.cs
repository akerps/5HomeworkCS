/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2  */

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

int [] ArrayOfNumbers = FillArray(4);
PrintArray(ArrayOfNumbers);

int EvenNumbers (int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0)
       {
        count++;
       }
    }
    return count;
}

int result = EvenNumbers(ArrayOfNumbers);
Console.Write($" -> {result}");