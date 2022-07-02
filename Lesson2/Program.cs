/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
string a = Console.ReadLine();
if (a.Length < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine("Третья цифра: " + a[2]);
}
*/


/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Вариант1

Console.WriteLine("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine());

if(day<=5)
{
    Console.WriteLine("рабочий");
}
else
{
    Console.WriteLine("выходной");
}

Вариант 2 с void
*/
int day = 4;
Zadacha15();
day = 7;
Zadacha15();
Console.WriteLine();
Console.WriteLine();
void Zadacha15()
{
    Console.WriteLine("______________");
    Console.WriteLine("Задача 15");
    if (day == 6 || day == 7)
    {
        Console.WriteLine("Это выходной день");
    }
    else
    {
        Console.WriteLine("Это рабочий день");
    }
}