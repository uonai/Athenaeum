using AthenaeumLibrary;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SqlClient;
using System.Reflection;

namespace Athenaeum
{
    class Program
    {
        public static void Main(string[] args)
        {


            DataAccess.GetUsers();
            Message.WelcomeMessage("Welcome to Athenaeum.");
            Console.WriteLine("Type --help for commands.");
            Message.IntroMessage();
            while (true)
            {
                string command;
                command = Console.ReadLine();
                if (command == "exit")
                {
                    break;
                }
                Command.Decipher(command);
            }                    
        }


        public static BookModel GetBook()
        {
            return new BookModel
            {
                Title = "Test",
                Author = "Test",
                Rating = 1,
                Review = "Test",
                Notes = "Test",
                Category = "Test"
            };       
        }

        public static UserModel AddUser()
        {
            return new UserModel
            {
                Name = "Test",
                Notes = "Test"
            };
        }
    }
}
