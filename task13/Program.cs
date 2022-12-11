// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
if (number > 99)
Console.WriteLine("Третья цифра этого числа: "+stringNumber[2]);
else
Console.WriteLine("Третьей цифры нет");