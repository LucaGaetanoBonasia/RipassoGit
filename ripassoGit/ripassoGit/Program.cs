using System;
namespace ripassoGit
{
    internal class Program
    {
        static string path = "file.txt";
        static void Main(string[] args)
        {
            Read read = new Read();
            Write write = new Write();
            Console.WriteLine("Inserisci un messaggio da scrivere nel file");
            string message = Console.ReadLine();
            write.Scrivi(message);
            Console.WriteLine("Contenuto del file:");
            read.Leggi();

        }
    }
}