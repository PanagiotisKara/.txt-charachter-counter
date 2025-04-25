using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
 
        string filePath = @"PATH TO TXT";
        

        foreach (string line in File.ReadLines(filePath))
        {

            string[] fields = line.Split('|');

            Console.WriteLine("Νέα γραμμή:");


            for (int i = 0; i < fields.Length; i++)
            {
                string fieldValue = fields[i];
                int charCount = fieldValue.Length;
                int byteCount = Encoding.Unicode.GetByteCount(fieldValue);

                Console.WriteLine($"  Line {i+1}: \"{fieldValue}\" | Charachters: {charCount} | Bytes (UTF-16): {byteCount}");
            }
            Console.WriteLine(new string('-', 40));
        }
        
        Console.WriteLine("Finished . . .");
        Console.ReadLine();
    }
}