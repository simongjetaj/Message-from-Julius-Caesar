using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Encrypt("EXPERIENCE IS THE TEACHER OF ALL THINGS", 4);
        }
        
        public static void Encrypt(string text, int key)
        {
            string result = "";

            for (int i = 0, textLength = text.Length; i < textLength; i++)
            {
                char letter = (!Char.IsWhiteSpace(text[i])) ? (char)(text[i] + key) : (char)(text[i]);
                int number = (int)letter;

                if (number < 65)
                {
                    if (number == 32)
                    { // if that's a space
                        number += 0;
                    }
                    else
                    {
                        number += 26;
                    }
                }
                
                if (number > 90)
                    number -= 26;
                
                char l = (char)number;
                result += l.ToString();
            }

            Console.WriteLine(result);
        }
     }
  }
