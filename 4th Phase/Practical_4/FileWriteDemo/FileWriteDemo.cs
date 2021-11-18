using System;
using System.IO;

namespace FileWriteDemo
{
    class FileWriteDemo
    {
        static void Main(string[] args)
        {
            FileStream fileStream;
            StreamWriter streamWriter;
            try
            {
                // if given path not found then FileNotFoundException exception thrown
                fileStream = new FileStream("../../../FileWritten.txt", FileMode.Create);

                // if user Don't have permission to open Then IOException will be thrown 
                streamWriter = new StreamWriter(fileStream);
                if (streamWriter == null)
                {
                    // if streamWriter don't Initialize properly then NullReferenceException will be thrown
                    throw new NullReferenceException();
                }
                streamWriter.WriteLine("Hello World!.");
                streamWriter.Close();
                fileStream.Close();


            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                
                Console.WriteLine("File Created and Written Successfully.");
            }
        }
    }
}
