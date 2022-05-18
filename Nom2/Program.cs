Console.WriteLine("Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("Введите число: ");
int a;
a = Convert.ToInt32(Console.ReadLine()); 
if(a>99)
{
    Console.WriteLine(a.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

