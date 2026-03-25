using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TextProcessor processor = new TextProcessor();

            string inputFile = @"E:\Visual Studio Insader\Projects\Test\textPD21.txt";
            string outputFile = @"E:\Visual Studio Insader\Projects\Test\resultPD21.txt";

            File.AppendAllText(outputFile, "=== UPPERCASE ===\n");
            processor.ProcessFile(inputFile, outputFile, processor.ToUpperCase);
            File.AppendAllText(outputFile, "\n=== CHAR COUNT ===\n");
            processor.ProcessFile(inputFile, outputFile, processor.CountChars);
            File.AppendAllText(outputFile, "\n=== WORD COUNT ===\n");
            processor.ProcessFile(inputFile, outputFile, processor.CountWords);
        }
    }
}