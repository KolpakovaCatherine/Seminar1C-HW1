/*Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.WriteLine("Введите первое число: ");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondDigit = Convert.ToInt32(Console.ReadLine());

if (FirstDigit > SecondDigit)
{
    Console.WriteLine($"max = {FirstDigit}, min = {SecondDigit}");
}
else
{
    Console.WriteLine($"max = {SecondDigit}, min = {FirstDigit}");

}