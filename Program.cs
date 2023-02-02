// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input your first number: "); // выводим сообщение пользователю
int number_1 = Convert.ToInt32(Console.ReadLine()); // вводим первое число

Console.Write("Input your second number: "); // выводим сообщение пользователю
int number_2 = Convert.ToInt32(Console.ReadLine()); // вводим второе число

if (number_1 > number_2) // сравниваем два числа
{
    Console.WriteLine($"max = {number_1}, min = {number_2}"); // выводим максимальное и минимальное в зависимости от сравнения
}
else
{
    Console.WriteLine($"max = {number_2}, min = {number_1}");
}
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input your first number: "); // выводим сообщение пользователю
int number_1 = Convert.ToInt32(Console.ReadLine()); // вводим первое число

Console.Write("Input your second number: "); // выводим сообщение пользователю
int number_2 = Convert.ToInt32(Console.ReadLine()); // вводим второе число

Console.Write("Input your third number: "); // выводим сообщение пользователю
int number_3 = Convert.ToInt32(Console.ReadLine()); // вводим третье число

if (number_1 > number_2 && number_1 > number_3) // задаем условие, что первое число максимальное 
{
    Console.WriteLine($"Maximum = {number_1}"); // выводим, что максимум это первое число
}
else
{
    if (number_2 > number_3) // задаем условие, что второе число максимальное
    {
        Console.WriteLine($"Maximum = {number_2}"); // выводим, что максимум это второе число
    }
    else
    {
        Console.WriteLine($"Maximum = {number_3}"); // выводим, что максимум это третье число
    }
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input your number: "); // выводим сообщение пользователю
int number = Convert.ToInt32(Console.ReadLine()); // вводим число

if (number % 2 == 0) // проверяем четное ли введенное пользователем число
{
    Console.WriteLine($"Число {number} четное"); // выводим сообщение, что число четное
}
else
{
    Console.WriteLine($"Число {number} нечетное"); // выводим сообщение, что число нечетное
} 
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input your number N: "); // выводим сообщение пользователю
int number = Convert.ToInt32(Console.ReadLine()); // вводим число

int current_number = 2; // текущее (начальное) число последовательности

while (current_number <= number) // начало цикла: текущее число должно быть меньше либо равно введенного пользователем числа
{
    if (current_number % 2 == 0) // условие, что текущее число четное
    {
        Console.Write(current_number + " "); // выводим текущее число и пробел
        current_number = current_number + 2; // увеличиваем текущее число на 2
    }
    else 
    {
        current_number = current_number + 1; // если изначально текущее число было нечетным, увеличиваем его на 1
    }
}



