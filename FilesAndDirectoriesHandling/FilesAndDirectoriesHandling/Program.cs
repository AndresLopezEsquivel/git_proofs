using System;
using System.IO;

namespace FilesAndDirectoriesHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentDate = DateTime.Now.ToString("yy_MM_dd");

            string path = @"../../../../Flights/" + currentDate;

            int numberOfTheLastFlight = 0;

            // string current_directory = Directory.GetCurrentDirectory();

            // Console.WriteLine(current_directory);

            if(Directory.Exists(path))
            {
                Console.WriteLine("The directory exists");

                string[] fileEntries = Directory.GetFiles(path);

                foreach (string file in fileEntries)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);

                    int lastCharIndex = fileName.Length - 1;

                    char lastChar = fileName[lastCharIndex];

                    // int numberOfFlight = Char.GetNumericValue(lastChar);

                    int numberOfFlight = Int32.Parse(lastChar.ToString());

                    if (numberOfTheLastFlight < numberOfFlight)
                    {
                        numberOfTheLastFlight = numberOfFlight;
                    }

                    Console.WriteLine(numberOfFlight);
                } 

            }
            else
            {
                Console.WriteLine("The directory doesn't exist but It has just been created.");

                Directory.CreateDirectory(path);
            }

            Console.WriteLine("Number of the last flight:" + numberOfTheLastFlight);

        }
    }
}
