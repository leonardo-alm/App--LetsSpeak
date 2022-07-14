using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Sharprompt;

namespace LetsSpeak
{
    public static class SpeakDictionary
    {
        public static Dictionary<string, string> Dict = new Dictionary<string, string>();

        public static void AddTerm()
        {
            Console.WriteLine("Informe o termo que deseja registrar:");
            string term = Console.ReadLine();

            bool invalidTerm = Regex.IsMatch(term, (@"[^A-Za-z\s]"));

            if (!invalidTerm)
            {
                Console.WriteLine("Informe o significado do termo:");
                string meaning = Console.ReadLine();

                Dict.Add(term, meaning);
                Database.SaveDictionary();
            }
            else
            {
                Console.WriteLine("Termo inválido!");
            }
        }

        public static void SearchTerm()
        {
            Console.WriteLine("Informe o termo que deseja pesquisar:");
            string term = Console.ReadLine();

            int termsFound = 0;

            foreach (string key in Dict.Keys)
            {
                if (key.Contains(term, StringComparison.CurrentCultureIgnoreCase))
                {
                    termsFound++;
                    Console.WriteLine(key);
                 }
            }
            if (termsFound == 0)
            {
                Console.WriteLine("Nenhum termo encontrado");
            }
        }
    }
}
