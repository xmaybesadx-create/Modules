using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Test
{
    public class TextProcessor
    {
        public delegate string TextOperation(string text);

        public void ProcessFile(string inputPath, string outputPath, TextOperation operation)
        {
            string[] lines = File.ReadAllLines(inputPath);
            foreach (string line in lines)
            {
                string result = operation(line);
                File.AppendAllText(outputPath, result + "\n");
            }
        }
        public string ToUpperCase(string text)
        {
            return text.ToUpper();
        }
        public string CountChars(string text)
        {
            return text.Length.ToString();
        }
        public string CountWords(string text)
        {
            return text.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length.ToString();
        }
    }
}
