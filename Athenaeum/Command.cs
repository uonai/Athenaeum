﻿using AthenaeumLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Athenaeum
{
    public class Command
    {
        public static void Decipher<T>(T command)
        {
            if (command.Equals("--getBooks"))
            {
                DataAccess.GetBooks();
            }
            else if (command.Equals("--addBook"))
            {
                Message.AddBookMessage();
                AddBook();
            }
            else if (command.Equals("--deleteBook"))
            {
                Message.DeleteBookMessage();
                DeleteBook();
            }
            else if (command.Equals("--addUser"))
            {
                Message.AddUserMessage();
                AddUser();
            }
            else if (command.Equals("--getUsers"))
            {
                DataAccess.GetUsers();
            }
            else if (command.Equals("--help"))
            {
                Console.Clear();
                Message.HelpMessage();
            }
            else { Message.NotRecognizedMessage(); }
            return;
        }

        public static void AddBook()
        {
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
                DataAccess.AddBook(book);
                Console.WriteLine("Item Saved");

                return;
            }
            else return;
        }

        public static void DeleteBook()
        {
            var book = new BookModel
            {
                Title = "",
            };

            Console.WriteLine("Book Title:");
            book.Title = Console.ReadLine();
            Console.WriteLine("Is this Correct? Would you like to delete this book [Y / N]");
            Console.WriteLine(book.Title);
            string confirmation = Console.ReadLine();
            if (confirmation.ToLower().Equals("y"))
            {
                DataAccess.DeleteBook(book);
                Console.WriteLine("Item Deleted");

                return;
            }
            else return;
        }

        public static void AddUser()
        {
            var user = new UserModel
                {
                    Name = "",
                    Notes = "",
                };

                Console.WriteLine("User Name:");
                user.Name = Console.ReadLine();
                Console.WriteLine("User Notes:");
                user.Notes = Console.ReadLine();
                Console.WriteLine("Is this Correct? [Y / N]");
                Console.WriteLine(user.Name + ", " + user.Notes);
                string confirmation = Console.ReadLine();
                if (confirmation.ToLower().Equals("y"))
                {
                    DataAccess.AddUser(user);
                    Console.WriteLine("Item Saved");
                    
                    return;
                }
                else return;
        }
    }
}
