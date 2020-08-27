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
        public static void IntroMessage()
        {
            Console.WriteLine("list of messages");
        }

        public static void NotRecognizedMessage()
        {
            Console.WriteLine("not recognized message");
        }
        public static void HelpMessage()
        {
            Console.WriteLine("help messages");
        }
        public static void AddUserMessage()
        {
            Console.WriteLine("add user message");
        }
        public static void AddBookMessage()
        {
            Console.WriteLine("add book message");
        }
    }
}
