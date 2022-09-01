using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CzatbotLite.Models;
using NLipsum.Core;

namespace CzatbotLite.Models
{
    internal class SentenceProcessor
    {

        public static string FindTheLongestWord(string sentence)
        {
            string[] strings = sentence.Split(' '); 
            string word = "";
            int i = 0;

            while (i < strings.Length)
                if (strings[i].Length > word.Length)
                {
                    word = strings[i];
                    i++;
                }
                else
                {
                    i++;
                    continue;
                }

            return word;
        }

    }
}

