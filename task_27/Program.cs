// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int temp = number;

int count = 1;
while (temp >= 10)
{
    temp = temp / 10;
    count = count + 1;
}
Console.WriteLine("счетчик " + count);

int extend = count - 1;
int result = 0;

while (extend != 0)
{
    int firstDigit = number / Convert.ToInt32(Math.Pow(10, extend));
    number = number % Convert.ToInt32(Math.Pow(10, extend));
    result = result + firstDigit;
    extend = extend - 1;
    Console.WriteLine("новый number: " + number);
    Console.WriteLine("первая цифра: " + firstDigit);
    Console.WriteLine("сумма: " + result);
    if (number < 10)
    {
        result = result + number;
    }
    Console.WriteLine("сумма итого: " + result);
}
