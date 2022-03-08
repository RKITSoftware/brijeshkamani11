using System;
using System.IO;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileInfo objFileInfo = new FileInfo("..\\..\\..\\tempfile.txt");

                // Creating, Appending and Reading File

                Console.WriteLine("Creating new  tempfile.txt.");
                using (StreamWriter objStreamWriter = objFileInfo.CreateText())
                {
                    objStreamWriter.WriteLine("Hello World...");
                }
                Console.WriteLine("File Created..");

                Console.WriteLine("Appending Text into tempfile.txt.");
                using (StreamWriter objStreamWriter = objFileInfo.AppendText())
                {
                    objStreamWriter.WriteLine("New Line Appended...");
                }
                Console.WriteLine("File Appended..");

                Console.WriteLine("\nReading Created File...");
                using (StreamReader objStreamReader = objFileInfo.OpenText())
                {
                    string line = "";
                    while ((line = objStreamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }

                }

                // Some Properties
                Console.WriteLine("\nHere are Some Information about Created File...");
                Console.WriteLine("\nFile Exist or not: " + objFileInfo.Exists);
                Console.WriteLine("File Name: " + objFileInfo.Name);
                Console.WriteLine("File FullName: " + objFileInfo.FullName);
                Console.WriteLine("File Length: " + objFileInfo.Length);
                Console.WriteLine("File DirectoryName: " + objFileInfo.DirectoryName);
                Console.WriteLine("File Directory: " + objFileInfo.Directory);
                Console.WriteLine("File Extension: " + objFileInfo.Extension);
                Console.WriteLine("Is File Read Only: " + objFileInfo.IsReadOnly);
                Console.WriteLine("File Creation Time: " + objFileInfo.CreationTime);
                Console.WriteLine("File Last Access Time: " + objFileInfo.LastAccessTime);

                // Coping, Moving and Deleting File
                Console.WriteLine("\nCoping file into tempfile_copy.txt.");
                objFileInfo.CopyTo("..\\..\\..\\tempfile_copy.txt");
                Console.WriteLine("Is Copied file created: " + File.Exists("..\\..\\..\\tempfile_copy.txt"));

                Console.WriteLine("\nMoving file into tempfile_moved.txt.");
                objFileInfo.MoveTo("..\\..\\..\\tempfile_moved.txt");
                Console.WriteLine("Is file Moved: " + File.Exists("..\\..\\..\\tempfile_moved.txt"));

                Console.WriteLine("\nDeleting Moved file");
                objFileInfo.Delete();
                Console.WriteLine("Is Moved File Deleted: " + !File.Exists("..\\..\\..\\tempfile_moved.txt"));

            }
            catch (IOException ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n" + ex.Message);
            }
        }
    }
}
