using AthenaeumLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Athenaeum
{
    public class Command
    {
        public static void Decipher<T>(T command)
        {
            if (command.Equals("--addBook"))
            {
                Message.AddBookMessage();

                var book = new BookModel
                {
                    Title = "",
                    Author = "",
                };

                Console.WriteLine("Book Title:");
                book.Title = Console.ReadLine();
                Console.WriteLine("Author Name:");
                book.Author = Console.ReadLine();
                Console.WriteLine("Is this Correct? [Y / N]");
                Console.WriteLine(book.Title + ", " + book.Author);
                string confirmation = Console.ReadLine();
                if (confirmation.ToLower().Equals("y"))
                {
                    Console.WriteLine("Item Saved");
                    return;
                }
                else return;
            }
            else if (command.Equals("--addUser"))
            {
                Message.AddUserMessage();
            }
            else if (command.Equals("--help"))
            {
                Message.HelpMessage();
            }
            else { Message.NotRecognizedMessage(); }
        }
    }
}
