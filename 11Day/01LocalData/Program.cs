using System;
using System.IO;
using System.Text;

namespace _01LocalData
{
    class Program
    {
        static void Main(string[] args)
        {
            // Path is a static class that helps you in paths.

            // you should normally abstain from the absolute paths, instead you should use a relative path.

            // for example: relativ path
            var path = "MyOneDirectory";

            //and absolute path
            Console.WriteLine($"This is a relativ path: {path}\n");
            Console.WriteLine($" and this is the absolute path of the path above: {Path.GetFullPath(path)}\n");

            Console.WriteLine($"A random file: {Path.GetRandomFileName()}\n");

            Console.WriteLine($"The temporal directory: {Path.GetTempPath()}");

            var tempFile = Path.GetTempFileName();

            Console.WriteLine($"The temporal file: {tempFile}");


            //This is not recommended:
            //"asdkfhakjsdfh.asdkfjhaksdfhk.asdklfjhaksdfhkasdfh.kajsdhfkasdhfk.txt"
            //var tempFileExt = tempFile.Split('.');
            //var ext = tempFileExt[tempFileExt.Length - 1];

            //always use the corresponding functions !

            Console.WriteLine($"GetFileNameWithoutExtension of temporal file: {Path.GetFileNameWithoutExtension(tempFile)}");

            Console.WriteLine($"GetExtension of temporal file: {Path.GetExtension(tempFile)}");

            Console.WriteLine($"GetDirectoryName of temporal file: {Path.GetDirectoryName(tempFile)}");


            var dirName = Path.Combine("egy", "ketto", "harom");

            // For directory operations: Directory (static class)
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }

            Console.WriteLine($"This is the relative directory: {dirName}");
            Console.WriteLine($" and this is the absolute path of the path above: {Path.GetFullPath(dirName)}");


            // File operations are performed by the File (Static) class.
            var fileName = "test.txt";
            File.WriteAllText(fileName, string.Format("I can write text {0} , \n or special characters: {1}, {2}, {3}, {4}, {5}"
                , "definitely"
                , Environment.NewLine    // a new line corresponding to that runtime environment
                , (char)113              // ascii code character (q)
                , Convert.ToChar(115)    // the same thing in other way (differently) (s)
                , '\u0027'               // unicode character  (')
                , new string(Encoding.ASCII.GetChars(new byte[] { 35, 36 })) // (#$) bytes of a character array containing ascii characters from the code of the characters
                                                                             // and then we can produce text from this
                ),
                Encoding.UTF8); //if you want, you can also enter text encoding. In this case, we must also give it by rewriting, in fact, it is always worth it


            //We have these options by writing , it always overwrites the file
            //File.WriteAllBytes
            //File.WriteAllLines
            //File.WriteAllText

            //the pair of these readers:
            //File.ReadAllBytes
            //File.ReadAllLines
            //File.ReadAllText

            //We can add to an existing file:
            //File.AppendAllLines
            //File.AppendAllText

            //Detailed File and Directory Information:
            //provides the FileInfo and the DirectoryInfo 
            var info = new FileInfo(fileName);
            Console.WriteLine($"This is a directoty: {info.Attributes.HasFlag(FileAttributes.Directory)}");

            Console.ReadLine();
        }
    }
}
