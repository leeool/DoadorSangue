int idade;

Console.Write("Digite sua idade: ");
idade = Convert.ToInt32(Console.ReadLine());

if (idade < 18)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você não pode doar sangue.");
}


else if (idade > 67)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Você não pode doar sangue.");
}

else
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("Você pode doar sangue!");
}
Console.ResetColor();