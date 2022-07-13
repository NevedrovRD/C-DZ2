//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int[] array = {1, 8};

int n = array.Length;
n = n - 1;

Console.WriteLine("Введите номер дня недели");

n = Convert.ToInt32(Console.ReadLine());

if (n < 1 || n > 7)
    Console.WriteLine("Неверный номер дня недели");
else    
    if (n < 6)
        Console.WriteLine("Будний день");
    else
        Console.WriteLine("Выходной день");

    if (n < 1 || n > 7)
        Console.WriteLine("Неверный номер дня недели");