// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result [i] = new Random().Next(start, end+1);
    }
    return result;
}

void printArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int getSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length;)
    {
        {
            sum += array[i];
            i = i+2;
        }
    }
    return sum;
}

int[] array = generateArray(4, -100, 100); // В задании сказано "задайте массив". Решил зафиксировать количество элементов 4 и поставить ограничение промежутка генерации сотнями, как в примере условия.
printArray(array);
int sum = getSum(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}.");