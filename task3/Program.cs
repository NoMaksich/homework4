void Function(int[] array)
{
    for(int i=0; i<8; i++)
    {
        array[i]=new Random().Next(0,100);
    }
    Console.Write("Значения массива: ");
    for(int i=0; i<8; i++)
    {
        Console.Write(array[i]+" ");
    }
}

int[] array=new int[8];
Function(array);
