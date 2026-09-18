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
int age = 16;
double height = 1.4;
bool hasAnAdult = true;
if ((age >= 14 && height >= 1.5) || hasAnAdult)
{
    Console.WriteLine("Можно кататься"); 
} else
{
    Console.WriteLine("Пока нельзя");
}
    