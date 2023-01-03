// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] NewArray()
{
    double[] array = new double[5];
    Console.Write("Массив {");
    for (int i =0; i <5; i++)
    {
        array[i] = 100 * Math.Round(new Random().NextDouble(), 4);
        Console.Write($"{array[i]}");
    }
    Console.WriteLine("}\n");
    return array;
}

void DiffEl(double[] newArray)
{
    int indexMax = 0;
    int indexMin = 0;
    for (int i = 1; i < newArray.Length; i++)
    {
        if (newArray[i] > newArray[indexMax]) indexMax = i;
        if (newArray[i] < newArray[indexMin]) indexMin = i;
    }
    Console.WriteLine($"Разница Max-Min = {Math.Round(newArray[indexMax] - newArray[indexMin], 2)}");
}
DiffEl(NewArray());