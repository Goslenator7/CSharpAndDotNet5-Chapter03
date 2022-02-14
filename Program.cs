using System;
using System.IO;

namespace chapter03
{
    class Program
        {
            static void Main(string[] args)
            {
                //Controlling flow and converting types

                int a = 3;
                int b = a++;
                Console.WriteLine($"a is {a}, b is {b}");
                Console.WriteLine("");


                int c = 3;
                int d = ++c;
                Console.WriteLine($"c is {c}, d is {d}");
                Console.WriteLine("");

                int age = 47;
                char firstDigit = age.ToString()[0];
                char secondDigit = age.ToString()[1];
                Console.Write($"{firstDigit} and {secondDigit}");
                Console.WriteLine("");

                Console.WriteLine("");

                //Selection Statements
                if (args.Length == 0)
                {
                    Console.WriteLine("There are no arguments");
                }
                else
                {
                    Console.WriteLine("There is at least one argument");
                }
                Console.WriteLine("");
                Console.WriteLine("");

                // Pattern matching
                //add or remove the "" to change behaviour
                object o = 3;
                int j = 4;

                if (o is int i)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                else
                {
                    Console.WriteLine("o is not an int so it cannot multiply");
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            // Switch statements
            A_label:
                var number = (new Random()).Next(1, 7);
                Console.WriteLine($"My random number is {number}");

                //switch (number)
                //    {
                //        case 1:
                //            Console.WriteLine("One");
                //            break;
                //        case 2:
                //            Console.WriteLine("Two");
                //            goto case 1;
                //        case 3:
                //        case 4:
                //            Console.WriteLine("Three or Four");
                //            goto case 1;
                //        case 5:
                //            //go to sleep for half a second
                //            System.Threading.Thread.Sleep(500);
                //            goto A_label;
                //        default:
                //            Console.WriteLine("Default");
                //            break;

                //    }

                //// Pattern matching with switch statement
                //string path = @"C: \Users\Ryan\Documents\Coding\C#AndDotNet5 Mk2\Chapter03\Chapter03\Program.cs";

                //Console.Write("Press R for read-only or W for write: ");
                //ConsoleKeyInfo key = Console.ReadKey();
                //Console.WriteLine();

                Stream s = null;

                //if (key.Key == ConsoleKey.R)
                //{
                //    s = File.Open(
                //        Path.Combine(path, "file.txt"),
                //        FileMode.OpenOrCreate,
                //        FileAccess.Read);
                //}
                //else
                //{
                //    s = File.Open(
                //        Path.Combine(path, "file.txt"),
                //        FileMode.OpenOrCreate,
                //        FileAccess.Write);
                //}

                string message = string.Empty;

                //switch (s)
                //{
                //    case FileStream writeableFile when s.CanWrite:
                //        message = "The stream is a file I can write to.";
                //        break;
                //    case FileStream readOnlyFile:
                //        message = "The stream is a read-only file";
                //        break;
                //    case MemoryStream ms:
                //        message = "The stream is a memory address";
                //        break;
                //    default:
                //        //always evaluated last despite its current position
                //        message = "The stream is some other type.";
                //        break;
                //    case null:
                //        message = "The stream is null";
                //        break;
                //}
                //Console.WriteLine(message);

                // Use Lambda to simplify the above
                message = s switch
                {
                    FileStream writeableFile when s.CanWrite
                        => "The stream is a file that I can write to.",
                    FileStream readOnlyFile
                        => "The stream is a read-only file",
                    MemoryStream ms
                        => "The stream is a memory address",
                    null
                    => "The stream is null.",
                    _   // default
                        => "The stream is some other type."
                };
            }
    }
}
