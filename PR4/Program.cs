//Вивести на екран текст, складений з перших букв усіх слів  даного файлу
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protected4
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string line; 
            char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; 
            using (StreamReader MyFile = new StreamReader("text.txt"))
            {
                IsEmpty(MyFile);              
                line = MyFile.ReadToEnd().Replace('\n', ' ');
            }
           
            string[] words = line.Split(separator);
            Console.WriteLine("First letter each words:");
            foreach (string word in words)
            {
               
                Console.Write(word[0]);
            }
            Console.ReadLine();
        }

        
        static void IsEmpty(StreamReader someFile)
        {
            someFile.BaseStream.Position = 0;
            if (someFile.ReadToEnd() == "")
            {
                Console.WriteLine("File is empty!");
                Environment.Exit(0);
            }
            someFile.BaseStream.Position = 0;
        }         
    }
}