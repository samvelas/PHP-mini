using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr4.Runtime;
using System.IO;
using Antlr4.Runtime.Tree;

namespace php
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter programm code in php syntax");
            Console.WriteLine("--------------------------------------------------");
            // В качестве входного потока символов устанавливаем консольный ввод
            AntlrInputStream input = new AntlrInputStream(Console.In);
            // Настраиваем лексер на этот поток
            phpLexer lexer = new phpLexer(input);
            // Создаем поток токенов на основе лексера
            CommonTokenStream tokens = new CommonTokenStream(lexer);
            // Создаем парсер
            phpParser parser = new phpParser(tokens);
            // И запускаем первое правило грамматики!!!
            Console.WriteLine("--------------------------------------------------");
            Console.Write("Result: ");
            IParseTree tree = parser.phpDoc();
            ParseTreeWalker walker = new ParseTreeWalker();
            visitFunction listener = new visitFunction();
            walker.Walk(listener, tree);

            //ParseTreeWalker.Default.Walk(new visitFunction(), tree);
                        
            Console.WriteLine("\n");
            Console.ReadKey();
                
        }
    }
}
