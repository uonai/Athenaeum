using AthenaeumLibrary;
using System;
using System.Reflection;

namespace Athenaeum
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.WelcomeMessage("Welcome to Athenaeum.");
            Console.WriteLine("Type --help for commands");
            Message.IntroMessage();
            string command;
            command = Console.ReadLine();

            if (command == "--addBook")
            {
                Message.AddBookMessage();
            }
            else if (command == "--addUser")
            {
                Message.AddUserMessage();
            }
            else { Message.NotRecognizedMessage(); }
        }

        public static BookModel GetBook()
        {
            return new BookModel
            {
                Title = "Test",
                Author = "Test",
            };       
        }
    }
}
