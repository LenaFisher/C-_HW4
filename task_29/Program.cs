// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8];
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Введите число " + (i + 1) + " из 8: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"[{string.Join(",", arr)}]");
