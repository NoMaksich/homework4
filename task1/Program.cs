int Prompt1()
{
    Console.Write("Введите число А: ");
    int limit =int.Parse(Console.ReadLine());
    return limit;
}

int Prompt2()
{
    Console.Write("Введите число B: ");
    int limit =int.Parse(Console.ReadLine());
    return limit;
}

int Degree(int one, int two)
{
    int result=one;
    for(int i=1; i<two; i++)
    {
        result=result*one;
    }
    return result;
}

int one=Prompt1();
int two=Prompt2();
int result= Degree(one, two);
Console.WriteLine($"Число {one} в степени {two} = {result}");

