// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int num = 8;
int [] arr = arrElement(num);
Console.WriteLine($"[{String.Join(",", arr)}]");

int [] arrElement(int size)
{
    int [] array = new int [size];
    for (int i=0;size>i;i++)
    {
        array [i]=new Random().Next(-100,101);
    }
    return array;
}


