// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
int num, num2;
Console.WriteLine($"Введите первое число  ");
num=EnterNum();
Console.WriteLine($"Введите второе число  ");
num2=EnterNum();
Console.WriteLine($"Число {num} в степени {num2} = {PowNum(num , num2)}");

int EnterNum ()
{
    int number = int.Parse(Console.ReadLine());
    return (number);
}

double PowNum(int number1 , int number2)
{
    double number3 = Math.Pow(number1, number2);
    return (number3);
}
