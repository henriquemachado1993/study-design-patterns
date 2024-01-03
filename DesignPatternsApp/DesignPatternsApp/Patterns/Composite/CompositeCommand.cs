using DesignPatternsApp.Interfaces;
using DesignPatternsApp.Patterns.Composite.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsApp.Patterns.Composite
{
    public class CompositeCommand : IPatternCommand
    {
        public void Execute()
        {
            Console.Clear();
            Console.WriteLine("###############################");
            Console.WriteLine("Padrão Composite");
            Console.WriteLine("###############################");
            Console.WriteLine();
            Console.WriteLine("Explicação: O padrão Composite é como organizar objetos em uma estrutura de árvore para representar partes e todo, onde partes individuais e composições de partes são tratadas de maneira uniforme.");
            Console.WriteLine("Contexto: Estrutura de pastas simples.");
            Console.WriteLine();

            Console.WriteLine("Digite um nome para criar um arquivo, exemplo: Minhas Anotações");
            var fileName1 = Console.ReadLine();

            var file1 = new FileSystem.File(fileName1);

            Console.WriteLine("Crie outro arquivo:");
            var fileName2 = Console.ReadLine();

            var file2 = new FileSystem.File(fileName2);

            Console.WriteLine("Agora crie uma pasta para salvar esses arquivos, pode ser qualquer nome:");
            var foldername = Console.ReadLine();

            var folder = new Folder(foldername);

            folder.Add(file1);
            folder.Add(file2);

            var rootFolder = new Folder("pasta-base");
            rootFolder.Add(folder);

            Console.WriteLine("Estrutura de Arquivos e Pastas:");
            rootFolder.Display();

            Console.WriteLine();
        }
    }
}
