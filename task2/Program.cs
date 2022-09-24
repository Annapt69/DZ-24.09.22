/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine($"Введите число от 1 до 7 где 1 -Понедельник, 2-Вторник, 3-Среда, 4-Четверг, 5-Пятница, 6-Суббота, 7-Воскресенье");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = {1, 2, 3, 4, 5, 6, 7};

if (number == array[0]) Console.WriteLine($"Нет");
else if (number == array[1]) Console.WriteLine($"Нет");
else if (number == array[2]) Console.WriteLine($"Нет");
else if (number == array[3]) Console.WriteLine($"Нет");
else if (number == array[4]) Console.WriteLine($"Нет");
else if (number == array[5]) Console.WriteLine($"Да");
else if (number == array[6]) Console.WriteLine($"Да"); 
