// Задача 15: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// Примеры:
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите цифру дня недели");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 6)
{
    Console.WriteLine("Рабочий день");
}
else if (number > 7)
{
    Console.WriteLine("Такого дня не существует");
}
else
{
    Console.WriteLine("Выходной день");
}