using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LetsSpeak
{
    public class Database
    {
        protected static readonly string rootDirectory = AppDomain.CurrentDomain.BaseDirectory;
        protected static readonly string dictionaryDb = Path.Combine(rootDirectory, "dictionary.xml");

        public static void SaveDictionary()
        {
            Console.WriteLine("Salvando...");

            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(Dictionary<string, string>));
            using (TextWriter writer = new StreamWriter(dictionaryDb))
            {
                dictionarySerializer.Serialize(writer, SpeakDictionary.Dict);
            }
            Console.WriteLine("Salvo.");
        }

        public static void LoadDictionary()
        {

            XmlSerializer dictionarySerializer = new XmlSerializer(typeof(Dictionary<string, string>));
            using (TextReader reader = new StreamReader(dictionaryDb))
            {
                var dictionary = dictionarySerializer.Deserialize(reader) as Dictionary<string, string>;
                SpeakDictionary.Dict = dictionary ?? new Dictionary<string, string>();
            }
        }
    }
}
