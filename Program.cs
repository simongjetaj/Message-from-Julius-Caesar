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
                char letter;
                int letterToNumber;

                if (Char.IsLetter(text[i]) && Char.IsLower(text[i]))
                {
                    letter = (char)(text[i] + key);
                    letterToNumber = (int)letter;
                    
                    if (letterToNumber < 101) // 'a'
                        letterToNumber += 26;
                    if (letterToNumber == 124) // '|'
                        letterToNumber -= 26;

                    if (letterToNumber > 126)
                        letterToNumber -= 26;
                }
                else if (Char.IsLetter(text[i]) && Char.IsUpper(text[i]))
                {
                    letter = (char)(text[i] + key);
                    letterToNumber = (int)letter;

                    if (letterToNumber < 65) // 'A'
                        letterToNumber += 26;

                    if (letterToNumber > 90) // 'Z'
                        letterToNumber -= 26;
                }
                else
                {
                    letter = (char)(text[i]);
                    letterToNumber = (int)letter;
                    letterToNumber += 0;
                }

                char l = (char)letterToNumber;
                result += l.ToString();
            }

            Console.WriteLine(result);
        }
     }
  }
