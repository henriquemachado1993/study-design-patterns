using DesignPatternsApp.Command;

bool closeProgram = false;
PatternInvoker patternInvoker = new PatternInvoker();

Console.WriteLine("#################################################################");
Console.WriteLine("Bem vindo ao debug de padrões de projetos mais usados do mercado!");
Console.WriteLine("#################################################################");
Console.WriteLine();
Console.WriteLine("Antes de iniciar, me informe qual padrão de projeto deseja debugar:");

while (!closeProgram)
{
    Console.WriteLine("Digite o código correspodente ao padrão desejado"); 
    Console.WriteLine("[0] - Para executar todos");
    Console.WriteLine("Criacionais");
    Console.WriteLine("[1] - Singleton");
    Console.WriteLine("[2] - Factory Method");
    Console.WriteLine("[3] - Abstract Factory");
    Console.WriteLine("Estruturais");
    Console.WriteLine("[4] - Facade");
    Console.WriteLine("[5] - Adapter");
    Console.WriteLine("[6] - Composite");
    Console.WriteLine("Comportamentais");
    Console.WriteLine("[7] - Strategy");
    Console.WriteLine("[8] - Interator");
    Console.WriteLine("[9] - Observer");

    string? patternId = Console.ReadLine();

    if (!string.IsNullOrEmpty(patternId) && patternId.ToUpper() == "0")
        patternInvoker.ExecuteAllCommand();
    else
        patternInvoker.ExecuteCommand(patternId);

    Console.WriteLine("Deseja encerrar o estudo? [S] sim, [N] não");
    string? closeProgramResult = Console.ReadLine();
    if (!string.IsNullOrEmpty(closeProgramResult) && closeProgramResult.ToUpper() == "S")
        closeProgram = true;
    else { Console.Clear(); }
}


