using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CzatbotLite.Models;

namespace CzatbotLite
{
    internal class Program
    {



          static void Main(string[]args)
        {
            Console.WriteLine("Enter your name.");           
            string name =  Console.ReadLine(); //Volodymyr
            Console.WriteLine("Helow " + name + " How are you?");
            string answer = Console.ReadLine(); // Very good
            Console.WriteLine("What does mean " + answer);
            string sentence = Console.ReadLine(); // Very good is good deeds

            string word = SentenceProcessor.FindTheLongestWord(sentence);
            Console.WriteLine(word);
            Console.ReadKey();
        }
    }
}
