Console.WriteLine("Программа которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа");
Console.WriteLine("Введите число: ");
int n;
n = Convert.ToInt32(Console.ReadLine()); 
int b = n /10;
int a = b%10;
Console.WriteLine(a);