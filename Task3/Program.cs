// НАЙДИТЕ СУММУ ЦИФР В ЧИСЛЕ

int sum_of_numbers(int number)
{
    if(number < 10)
    return number;
    int num1 = number%10;
    int next_number = number/10;
    int sum = num1 + sum_of_numbers(next_number);
    return sum;
}
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе {number} = {sum_of_numbers(number)}");
