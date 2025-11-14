using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ripassoGit
{
    internal class Write
    {

        public string Path { get; private set; }
        public Write(string path)
        {
            Path = path;
        }

        public void  Scrivi(string content)
        {
            using (StreamWriter writer = new StreamWriter(Path))
            {
                writer.Write(content);
            }

            Console.WriteLine("File scritto con successo");
        }
        
    }
}
