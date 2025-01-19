using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFiles
{
    internal class Methods
    {
        //TODO validaçoes para nao crashar quando se tenta aceder a uma pasta que nao existe.    
        public static void SearchDirectory(string path)
        {
            string[] dirs = Directory.GetDirectories(path, "*.*", SearchOption.AllDirectories);
            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }
        }
    }
}
