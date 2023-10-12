Console.Write("Введите имя пользовотеля: ");
string username = Console.ReadLine();

if(username.ToLower() == "Solo")
{
    Console.WriteLine("Ура, это же SOLO!");    
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
