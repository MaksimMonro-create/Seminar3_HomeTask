// НАЙТИ КУБЫ ЧИСЕЛ ОТ 1 ДО N
Console.Clear();
Console.WriteLine();

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());


int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{number} в кубе = ");
        Console.WriteLine(array[i]);
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintCubs(CubeTable);
