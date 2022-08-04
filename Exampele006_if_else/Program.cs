Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") // ToLower() переводит при вводе все в нижний регистор
{
    Console.WriteLine ("Ура,это же Маша!");
    }
else
{
    Console.Write ("Привет, ");
    Console.WriteLine (username);
}