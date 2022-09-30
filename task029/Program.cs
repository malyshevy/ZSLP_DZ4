// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int num = 8;
int [] arr = arrElement(num);
Console.WriteLine($"Весь массив : [{String.Join(",", arr)}]");

int [] arrElement(int size)
{
    int [] array = new int [size];
    for (int i=0;size>i;i++)
    {
        Console.Write($"Введите {i+1} элемент из 8-ми элементов массива : ");
        array [i]=int.Parse(Console.ReadLine());
    }
    return array;
}
