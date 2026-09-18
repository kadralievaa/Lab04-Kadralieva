// int age = 15;
// if (age >= 21)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// Console.WriteLine("Программа продолжает работу");
// //2
// int age1 = 15;
// if (age1 >= 18)
// {
//     Console.WriteLine("Доступ разрешен");
// }
// else
// {
//     Console.WriteLine($"Доступ запрещен, вернитесь через {21 - age1} лет");
// }

//3
// int age = 67;
// if (age < 13)
// {
//     Console.WriteLine("Ребенок");
// }
// else if (age < 18)
// {
//     Console.WriteLine("Подросток");
// }
// else if (age < 60)
// {
//     Console.WriteLine("Взрослый");
// } else {
//     Console.WriteLine("Пенсионер");
// }

//4
// int age = 16;
// double height = 1.4;
// bool hasAnAdult = true;
// if ((age >= 14 && height >= 1.5) || hasAnAdult)
// {
//     Console.WriteLine("Можно кататься"); 
// } else
// {
//     Console.WriteLine("Пока нельзя");
// }

//A
// Console.WriteLine();
// Console.Write("Введите число:  ");
// int num = int.Parse(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine($"Число {num} является четным");
// }
// else {
//     Console.WriteLine($"Число {num} является нечетным");
// }

// Б
// Console.WriteLine();
// Console.Write("Введите оценку (2-5): ");
// int grade = int.Parse(Console.ReadLine());

// if (grade == 5) {
//     Console.WriteLine("Отлично");
// } else if (grade == 4) {
//     Console.WriteLine("Хорошо");
// } else if (grade == 3) {
//     Console.WriteLine("Удовлетворительно");
// } else if (grade == 2) {
//     Console.WriteLine("Неудовлетворительно");
// } else {
//     Console.WriteLine("Неверная оценка");
// }

// Вариант 2
// Console.WriteLine();
// Console.WriteLine("Введите ваш возраст:  ");
// int age = int.Parse(Console.ReadLine());

// if (age >= 18) {
//     Console.WriteLine("Доступ разрешен");
// } else {
//     Console.WriteLine("Доступ запрещен");
// }

// Вариант 8
Console.WriteLine();
Console.WriteLine("Введите год: ");
int year = int.Parse(Console.ReadLine());

if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) {
    Console.WriteLine("Год високосный, в феврале 29 дней");
} else {
    Console.WriteLine("Год не високосный, в феврале 28 дней");
}