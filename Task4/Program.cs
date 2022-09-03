// НАПИСАТЬ ПРОГРАММУ ВЫЧИСЛЕНИЯ ПРОИЗВЕДЕНИЯ ЧИСЕЛ ОТ 1 ДО N
Console.Clear();
Console.WriteLine();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int GetNumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbersComposition(N)}");
Console.WriteLine();
