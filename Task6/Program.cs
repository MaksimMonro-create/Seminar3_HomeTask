
// ЗАДАТЬ МАССИВ ИЗ 8 ЭЛЕМЕТОВ, ЗАПОЛНЕННЫХ НУЛЯМИ И ЕДИНИЦАМИ, ВЫВЕСТИ ИХ НА ЭКРАН
Console.Clear();
int N = 8;
int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine($"{array[i]} ");
}

PrintArray(SetArray(N));