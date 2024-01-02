﻿bool closeProgram = false;

while (!closeProgram)
{
    Console.WriteLine("Bem vindo ao debug de padrões de projetos mais usados do mercado!");
    Console.WriteLine("Antes de iniciar, me informe qual padrão de projeto deseja debugar:");
    Console.WriteLine("Digite o código correspodente ao padrão desejado");
    Console.WriteLine("Criacionais");
    Console.WriteLine("[1] - Singleton");
    Console.WriteLine("[2] - Factory Method");
    Console.WriteLine("[3] - Abstract Factory");
    Console.WriteLine("Criacionais");
    Console.WriteLine("[4] - Facade");
    Console.WriteLine("[5] - Adapter");
    Console.WriteLine("[6] - Composite");
    Console.WriteLine("Criacionais");
    Console.WriteLine("[7] - Strategy");
    Console.WriteLine("[8] - Command");
    Console.WriteLine("[9] - Interator");
    Console.WriteLine("[10] - Observer");

    string? idPattern = Console.ReadLine();


    Console.WriteLine("Deseja encerrar o estudo? [S] sim, [N] não");
    string? closeProgramResult = Console.ReadLine();
    if (!string.IsNullOrEmpty(closeProgramResult) && closeProgramResult.ToUpper() == "S")
        closeProgram = true;

}

