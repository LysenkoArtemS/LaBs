using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class DictionaryTask
    {
        private Dictionary<string, int> dictionary;
        public DictionaryTask(string str)
        {
            char[] charSepatators = new char[] { ' ', '.'};
            string[] substr = str.Split(charSepatators, StringSplitOptions.RemoveEmptyEntries);
            dictionary = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase); 
            for (int i = 0; i < substr.Length; i++)
            {
                if (!dictionary.ContainsKey(substr[i]))
                {
                    dictionary.Add(substr[i], 1);
                }
                else 
                {
                    dictionary[substr[i]]++;
                }
            }          
        }
        public void PrintDictionary()
        {
            foreach (var word in dictionary)
            {
                Console.WriteLine($"word: {word.Key}\t ammount: {word.Value}");
            }
        }
    }
}
