using System;
using System.Collections.Generic;
using System.Text;

namespace CONSOLE.Methods
{
    public static class InputMethods
    { 
        public static string[] Split_String(string line)
        {
            string[] words = line.Split(new char[] { ' ' });
            return words;
        }

        public static string[] Read_Separated_String()
        {
            Console.Write(">");
            string line = Console.ReadLine();
            return Split_String(line);
        }

    }
}
