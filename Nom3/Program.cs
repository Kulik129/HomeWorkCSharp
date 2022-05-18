Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Введите число: ");
int b;
b = Convert.ToInt32(Console.ReadLine());
if(b<=5)
{
    Console.WriteLine("Нет это не выходной...");

}
else if(b>7)
{
    Console.WriteLine("Error! Error! Введите число меньше или равно 7");
}
else
{
    Console.WriteLine("Да-да-да!!!");
}
if(b==5)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Но пятница это маленькая суббота");
}