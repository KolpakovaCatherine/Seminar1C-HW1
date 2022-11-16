/*Напишите программу, которая принимает на вход три числа и выдаёт 
максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/

Console.WriteLine("Введите первое число: ");
int FirstDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int SecondDigit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int ThirdDigit = Convert.ToInt32(Console.ReadLine());

if (FirstDigit > SecondDigit)
{
    if (FirstDigit > ThirdDigit)
    {
        Console.WriteLine($"max = {FirstDigit}");
    }
    else
    {
        Console.WriteLine($"max = {ThirdDigit}");

    }
}
else if (SecondDigit > ThirdDigit)
{
    Console.WriteLine($"max = {SecondDigit}");

}
else
{
    Console.WriteLine($"max = {ThirdDigit}");
}