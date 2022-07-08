/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

double[] FillArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void ShowArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(" ");
        }
    }
    Console.Write("]");
}

double[] TrueArray = FillArray(5);
ShowArray(TrueArray);

double max = TrueArray[0];
double min = TrueArray[0];
for (int i = 1; i < TrueArray.Length; i++)
{
    if (TrueArray[i] > max)
    {
        max = TrueArray[i];
    }
    if (TrueArray[i] < min)
    {
        min = TrueArray[i];
    }
}

double difference = max - min;

Console.Write($" -> максимум = {max}, минимум = {min}, разница = {difference}.");