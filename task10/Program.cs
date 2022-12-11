// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
if (threeDigitNumber < 1000 && threeDigitNumber > 99)
Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);
else
Console.WriteLine("Ошибка");