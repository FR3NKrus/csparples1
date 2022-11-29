Console.Write("Введите Имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, привет Маша");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}