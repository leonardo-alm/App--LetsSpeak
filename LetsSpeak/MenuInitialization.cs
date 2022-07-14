using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsSpeak
{
    internal class MenuInitialization
    {
        public static void InitializeMenu()
        {
            var dictionary = new MenuItem("Dicionário");
            dictionary.Add(new MenuItem("Cadastrar Termo", SpeakDictionary.AddTerm));
            dictionary.Add(new MenuItem("Buscar Termo", SpeakDictionary.SearchTerm));
            dictionary.Add(new MenuItem("Sair", () => Environment.Exit(0)));
            dictionary.Execute();
        }
    }
}
