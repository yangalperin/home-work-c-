// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2; b = 10 -> max = 10
//a = -9; b = -3 -> max = -3
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int numberA = Convert.ToInt32(input1);
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);
if(numberA < numberB)
{
Console.WriteLine(numberB +" больше "+ numberA);
}
else
{
Console.WriteLine(numberA +" больше "+ numberB);
}