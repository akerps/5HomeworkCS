/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */ 

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-99, 100);
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

int SumOfOddNumbers(int[] array)
{
    int sumOfArray = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 != 0)
        {
            sumOfArray += array[i];
        }
    }
    return sumOfArray;
}

int [] NumbersArray = FillArray(4);
PrintArray(NumbersArray);

int OddSum = SumOfOddNumbers(NumbersArray);

Console.Write($" -> {OddSum}");
