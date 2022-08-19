// 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine("введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите степень числа: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i = 0; i < number2; i++)
{
    result = result * number1;
}
Console.WriteLine(result);