using System.IO;

namespace ExerciciosFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aceder a pastas
            string rootPath = @"C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiles\";

            //string[] dirs = Directory.GetDirectories(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            //{
            //    Console.WriteLine(dir);
            //}

            //aceder a ficheiros
            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            //{
            //    Console.WriteLine(file);
            //    Console.WriteLine(Path.GetFileName(file));
            //    Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //    Console.WriteLine(Path.GetFullPath(file));
            //    Console.WriteLine(Path.GetDirectoryName(file));
            //    var info = new FileInfo(file);
            //    Console.WriteLine($" {Path.GetFileName(file)}: {info.Length} bytes ");
            //}

            //string newPath = @"C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiless\";
            ////Directory.CreateDirectory(newPath); //Cria a nova diretoria sem perguntar

            //bool directoryExists =  Directory.Exists(@"C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiless\");

            //if (directoryExists)
            //{
            //    Console.WriteLine("Directory Exists");
            //}
            //else
            //{
            //    Console.WriteLine("Directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}

            //-------------------------------

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"C:\Projetos\ExerciciosFiles\ExerciciosFiles\TestFiles\SubFolderA";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder} {Path.GetFileName(file)}", true);
            //    Console.WriteLine(file);
            //}

            //for (int i = 0; i < files.Length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{i}.txt", true);
            //}

            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder} {Path.GetFileName(file)}");
            //    Console.WriteLine(file);
            //}

            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                //Console.WriteLine(Path.GetFileName(file));
                //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                //Console.WriteLine(Path.GetFullPath(file));
                //Console.WriteLine(Path.GetDirectoryName(file));
                //var info = new FileInfo(file);
                //Console.WriteLine($" {Path.GetFileName(file)}: {info.Length} bytes ");
            }
        }
    }
}
