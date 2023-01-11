Console.WriteLine("Введите имя пользователя");
string name = Console.ReadLine();

if (name.ToLower() == "маша")
{
    Console.WriteLine("Ура, это МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(name);
}
