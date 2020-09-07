using System;

namespace Athenaeum
{
    public class Message
    {
        public static void WelcomeMessage(string message)
        {
            string book = $"\n {message}";
            book += @"

    (\ 
    \'\ 
        \'\     __________  
        / '|   ()_________)
        \ '/    \ ~~~~~~~~ \
        \       \ ~~~~~~   \
        ==).      \__________\
        (__)       ()__________)
";
            Console.WriteLine(book);
        }

        public static void NotRecognizedMessage()
        {
            Console.WriteLine("Message not recognized. Type --help for commands");
        }
        public static void HelpMessage()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("--addUser");
            Console.WriteLine("--getUsers");
            Console.WriteLine("--addBook");
            Console.WriteLine("--getBooks");
            Console.WriteLine("--deleteBook");
        }
        public static void AddUserMessage()
        {
            Console.WriteLine("add user message");
        }
        public static void AddBookMessage()
        {
            Console.WriteLine("Add Book information --");
        }
        public static void DeleteBookMessage()
        {
            Console.WriteLine("Delete Book information --");
        }
    }
}
