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
            Message.WelcomeMessage("Welcome to Athenaeum.");
            Console.WriteLine("Type --help for commands.");
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
    }
}
