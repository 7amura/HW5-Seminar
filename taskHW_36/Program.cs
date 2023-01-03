// Задача 36: 
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19 ; [-4, -6, 89, 6] -> 0

int[] NewArray()
{
    Console.Write("Массив {");
    int[] array = new int[4];
    for(int i =0; i < 4; i++)
    {
        array[i] = new Random().Next(-100, 1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("}\n");
    return array;
}

void FindSum(int[] anyArray)
{
    int sum = 0;
    for( int i = 0; i < 4; i++)
    {
        if(i % 2 != 0) sum += anyArray[i];
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {sum}");
}
FindSum(NewArray());