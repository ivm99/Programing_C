Console.WriteLine("Введте ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, " + username);
    //Console.WriteLine(username);
}