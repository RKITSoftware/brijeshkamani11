using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionDemo
{
    class ExceptionDemo
    {
        static void Main(string[] args)
        {
            FileStream fileStream;
            StreamReader streamReader;
            try
            {
                List<string> files = new List<string>() { "temp.txt", "unknown.txt" };
                
                // here if Index doesn't given properly then IndexOutOfRangeException Exception will be thrown
                // if list contains null values than string may contains null Reference
                String fileName = files[0];
                
                // if given path not found then FileNotFoundException exception thrown
                fileStream = new FileStream(fileName, FileMode.Open);

                // if user Don't have permission to open Then IOException will be thrown 
                streamReader = new StreamReader(fileStream);
                if (streamReader == null)
                {
                    // if streamReader don't Initialize properly then NullReferenceException will be thrown
                    throw new NullReferenceException();
                }
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string str = streamReader.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = streamReader.ReadLine();
                }
                Console.ReadLine();
                streamReader.Close();
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
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            // if any other Exception occurs then This class will handle it.
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // If any exception occurs or not this block will be defiantly RUN.
            finally
            {
                Console.WriteLine("File Read Successfully");
            }
        }
    }
}
