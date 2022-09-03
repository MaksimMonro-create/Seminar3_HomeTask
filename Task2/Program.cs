// ВОЗВЕДИТЕ ЧИСЛО А В НАТУРАЛЬНУЮ СТЕПЕНЬ B, ИСПОЛЬЗУЯ ЦИКЛ

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение степени");
int step = int.Parse(Console.ReadLine());
int i;
int result = number;
for(i=2; i <=step; i++)
{
    result = result*number;
}
    if(step==1)
    {
        result = number;
    }


Console.WriteLine("Число в степени = " + result);
