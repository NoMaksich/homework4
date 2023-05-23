int Prompt()
{
    Console.Write("Введите число: ");
    int limit =int.Parse(Console.ReadLine());
    return limit;
}
int Sum(int number)
{
    int result=0;
    while(number>0)
    {
        result+=number%10;
        number=number/10;
    }
    return result;
}
int number=Prompt();
int result=Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");