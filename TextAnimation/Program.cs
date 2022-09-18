using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnimation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alphabet = new List<string>();
            List<int> indexes = new List<int>();
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower();
            /*for(int i = 1; i<= alpha.Length; i++)
            {
                alphabet.Add(alpha[i-1].ToString());
            }
            */
            Console.WriteLine("Your Text: ");
            string myText = Console.ReadLine();
            var type = Console.ReadLine();
            if(type == "text")
            {
                for (int i = 1; i <= myText.Length; i++)
                {
                    Console.Write(alpha[alpha.IndexOf(myText[i - 1].ToString())]);
                }
            }
            else if(type == "numeric")
            {
                for (int i = 1; i <= myText.Length; i++)
                {
                    Console.WriteLine(alpha.IndexOf(myText[i - 1].ToString()));
                }
            }
        }
    }
}
