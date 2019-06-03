using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 1 - Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini),
            //reads its contents and prints it on the console. Find in MSDN how to use System.IO.File.ReadAllText(...).
            //Be sure to catch all possible exceptions and print user-friendly error messages.

            Console.WriteLine("Introduceti locatia fisierului: ");
            string file = Console.ReadLine();

            try
            {
                Console.WriteLine(File.ReadAllText(file));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file is not found");
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("The specified path, file name, or both exceed the system-defined maximum length");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("The specified path is invalid");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("The file path is incrrect");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Path is in invalid format");
            }


            //Ex 2 - Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory. 
            //Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.

            Console.WriteLine("Introduceti adresa url: ");
            string url = Console.ReadLine();
            Console.WriteLine("Introduceti adresa unde va fi stocat fisierul: ");
            string directory = Console.ReadLine();

            WebClient webClient = new WebClient();
            try
            {
                webClient.DownloadFile(url, directory);
                Console.WriteLine("Descarcare finalizata");
            }
            catch (WebException)
            {
                Console.WriteLine("Invalid address");
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("The method has been called simultaneously on multiple threads");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Address can't be null");
            }
            finally
            {
                webClient.Dispose();
            }

            //Ex 3 - Write a method ReadNumber(int start, int end) that enters an integer number in a given range ( start, end )
            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("Enter number {0} in the range [{1}...{2}] : ", i, 1, 10);
                    int number = ReadNumberNr(1, 100, i);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Number is not integer");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Value can't be null");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is not in the range");
            }

            //64 Bit array
            var number1 = new BitArray64();
            number1[4] = 1;
            number1[10] = 1;

            Console.WriteLine(number1);

            var number2 = new BitArray64(1040);
            Console.WriteLine(number2);

            Console.WriteLine("number1 == number2: {0}", number1 == number2);
            Console.WriteLine("number1 != number2: {0}\n", number1 != number2);

            Console.WriteLine("number1.GetHashCode(): {0}", number1.GetHashCode());
            Console.WriteLine("new BitArray64(4198).GetHashCode(): {0}", new BitArray64(4198).GetHashCode());
        }
    }
}
