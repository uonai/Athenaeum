using AthenaeumLibrary;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace Athenaeum
{
    class Program
    {
        public static void Main(string[] args)
        {

            var host = CreateWebHostBuilder(args).Build();
            host.Run();

            Message.WelcomeMessage("Welcome to Athenaeum.");
            Console.WriteLine("Type --help for commands.");
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

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();

        public static void SeedDatabase(IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<MyDbContext>();
                    DbInitializer.Initialize(context, services);
                }
                catch (Exception)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError("An error occured seeding the db");
                }
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
