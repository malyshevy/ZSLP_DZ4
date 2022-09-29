// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
int num;
Console.Write($"Введите число  ");
num=EnterNum();
Console.WriteLine($"Сумма цифр в числе {num} = {SumNum(num)}  ");

int EnterNum ()
{
    int number = int.Parse(Console.ReadLine());
    return (number);
}

int SumNum (int number1)
{
    int sum=0,
        number2;
    for (;number1>0;)
    {
        number2 = number1 % 10;
        number1 /=10;
        sum=sum + number2;
    }
    return (sum);
}
