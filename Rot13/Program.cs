using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rot13
{
    class Program
    {
        public static string Rot13(string message)
        {
            string returnMessage = "";
            int number = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if(char.IsUpper(message[i]))
                {
                    if (message[i] + 13 > 90)
                    {
                        number = ((message[i] + 13) - 91) + 65;
                        returnMessage += ((char)(number)).ToString();
                    }
                    else
                    {
                        returnMessage += ((char)(message[i] + 13)).ToString();
                    }
                }
                else if(char.IsLower(message[i]))
                {
                    if (message[i] + 13 > 122)
                    {
                        number = ((message[i] + 13) - 123) + 97;
                        returnMessage += ((char)(number)).ToString();
                    }
                    else
                    {
                        returnMessage += ((char)(message[i] + 13)).ToString();
                    }
                }
                else if(!char.IsLetter(message[i]))
                {
                    returnMessage += message[i];
                }
            }
            return returnMessage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Rot13("test"));
            Console.WriteLine(Rot13("Test"));
            Console.WriteLine(Rot13("Codewars"));

            Console.ReadKey();
        }
    }
}
