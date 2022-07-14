using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace LetsSpeak
{
    public class Program
    {
        static void Main(string[] args)
        {
            MenuItem.SetPrompt();
            Console.Title = "Let's Speak";

            MenuInitialization.InitializeMenu();
        }       
    }
}
