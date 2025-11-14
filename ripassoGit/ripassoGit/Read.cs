using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripassoGit
{
    internal class Read
    {
        public string path { get; set; }
        public Read(string path)
        {
            this.path = path;
        }
        
        public void Leggi(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line= reader.ReadToEnd();
                Console.WriteLine(line);
            }
            Console.WriteLine("File letto con successo");           
        }
    }
}
