//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int n = new Random().Next(10, 100000);
Console.WriteLine(n);
if (n < 100)
    Console.WriteLine("Нужно 3х значное число");
else
    Console.WriteLine(Convert.ToString(n)[3]);