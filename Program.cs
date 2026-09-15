int age = 15;
if (age >= 21)
{
    Console.WriteLine("Доступ разрешен");
}
Console.WriteLine("Программа продолжает работу");

//2
int age1 = 15;
if (age1 >= 18) {
    Console.WriteLine("Доступ разрешен");
} else {
    Console.WriteLine($"Доступ запрещен, вернитесь через {21-age1} лет");
}