using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml;

string name;
string lastName;
int yearOfBirth;
int year = DateTime.Now.Year;

Console.Write("Работу выполнил Короткий Дмитрий\n");
Console.Write("Введите свое имя: ");

name = Console.ReadLine();
Console.Write("Введите свою фамилию: ");

lastName = Console.ReadLine();
Console.Write("Введите свой год рождения: ");

yearOfBirth = int.Parse(Console.ReadLine());
int age = year - yearOfBirth;

Console.Write($"Добавлен пользователь с именем: {name} {lastName}\n В возрасте: {age}");
Console.ReadLine();


<<<<<<< HEAD
string[] toDos = new string[2];
bool running = true;
=======
// Работа 3
string[] todos = new string[2];
int todoCount = 0;
bool running = true; //нужно для того чтобы exit останавливал работу, еще можно было сделать метод и через return
>>>>>>> 1dba62c (добавил работу команд view и add, но они не работают нормально. Пока что закомичу потом пофикшу.)

while (running){
    Console.WriteLine("Введите команду: ");
    string userInput = Console.ReadLine();

    switch (userInput){
        case "exit":
            Console.WriteLine("Завершение работы программы");
            running = false;
            break;

        case "help":
            Console.WriteLine("help — выводит это сообщение.");
            Console.WriteLine("profile — выводит данные пользователя в формате: <Имя> <Фамилия>, <Год рождения> .");
            Console.WriteLine("add — добавляет новую задачу. Формат ввода: add  \"текст задачи\".");
            Console.WriteLine("view — выводит все задачи из массива.");
            Console.WriteLine("exit — завершает цикл и останавливает выполнение программы.");
            break;

        case "profile":
            Console.WriteLine($"{name} {lastName}, {age}");
            break;

        case string s when s.StartsWith("add "):
            string task = s.Substring(4).TrimEnd('"');
            if (todoCount >= todos.Length){
                string[] newTodos = new string[todos.Length * 2];
                for (int i = 0; i < todos.Length; i++){
                    newTodos[i] = todos[i];
                }
                todos = newTodos;
            }
            todos[todoCount] = task;
            todoCount++;
            Console.WriteLine($"Добавлено: {task}");
            break;

        case "view":
            for (int i = 0; i < todos.Length; i++){
                bool temp = string.IsNullOrEmpty(todos[i]);
                switch (temp){
                    case true:
                        Console.WriteLine($"[{i + 1}] {todos[i]}");
                        break;
                    default:
                        Console.WriteLine("Список задач пуст");
                        break;
                }
            }
            break;

        default:
            Console.WriteLine("Неизвестная команда, введите help для вывода списка команд");
            break;
    }
}
