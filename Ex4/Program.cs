/*Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int Count = 1;

while (Count <= N)
{
    if (Count % 2 == 0)
    {
        if (Count < N-1) //убираем последнюю запятую
        {
            Console.Write($"{Count}, ");
        }
        else
        {
            Console.WriteLine (Count);
        }
    }
    Count++;
}