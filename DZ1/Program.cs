// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введи первое число:");
string num1 = Console.ReadLine();
int num1int = int.Parse(num1);

Console.WriteLine("Введи второе число:");
string num2 = Console.ReadLine();
int num2int = int.Parse(num2);

if (num1int > num2int)
{
    Console.WriteLine("Первое число больше!");

}

else if (num1int < num2int)
{
    Console.WriteLine("Второе число больше!");

}

else
{
    Console.WriteLine("Числа равны!");
}