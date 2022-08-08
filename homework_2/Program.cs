//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2 3 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Введите первое число: ");
string input1 = Console.ReadLine();
int numberA = Convert.ToInt32(input1);
Console.Write("Введите второе число: ");
string input2 = Console.ReadLine();
int numberB = Convert.ToInt32(input2);
Console.Write("Введите третье число: ");
string input3 = Console.ReadLine();
int numberС = Convert.ToInt32(input3);

int max = numberA;

if(max < numberB)
{
 max = numberB;  
}
if(max < numberС)
{
max = numberС;
}

Console.WriteLine(max + " - наибольшее число");