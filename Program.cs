using System;

string name;
string lastName;
int yearOfBirth;
int year = DateTime.Now.Year;

Console.Write("Работу выполнил Дмитрий Короткий\n");
Console.Write("Введите свое имя: ");

name = Console.ReadLine();
Console.Write("Введите свою фамилию: ");

lastName = Console.ReadLine();
Console.Write("Введите свой год рождения: ");

yearOfBirth = int.Parse(Console.ReadLine());
int age = year - yearOfBirth;

Console.Write($"Добавлен пользователь с именем: {name} {lastName}\n В возрасте: {age}");
Console.ReadLine();
