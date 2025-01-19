using System.IO;

namespace ExerciciosFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiles\";

            string[] dirs = Directory.GetDirectories(rootPath, "*.*", SearchOption.AllDirectories);

            foreach (string dir in dirs)
            {
                Console.WriteLine(dir);
            }


        }
    //TODO validaçoes
    
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
