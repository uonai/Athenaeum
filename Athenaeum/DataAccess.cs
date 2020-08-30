using AthenaeumLibrary;
using System;
using System.Data.SqlClient;

namespace Athenaeum
{
    public class DataAccess
    {
        public static void GetUsers()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=AthenaeumDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Users", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Id\t\tName\t\tNotes");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} ",
                        reader[0], reader[1], reader[2]));
                    }
                }
                Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                Console.ReadLine();
                Console.Clear();
            }
        }
        public static void GetUser()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=AthenaeumDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn.Open();
             
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE Id = @0", conn);
             
                command.Parameters.Add(new SqlParameter("0", 1));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Id\t\tName\t\tNotes");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} ",
                        reader[0], reader[1], reader[2]));
                    }
                }
                Console.WriteLine("Data displayed! Now press enter to move to the next section!");
                Console.ReadLine();
                Console.Clear();

                /* In this section there is an example of the Exception case 
  * Thrown by the SQL Server, that is provided by SqlException  
  * Using that class object, we can get the error thrown by SQL Server. 
  * In my code, I am simply displaying the error! */
                Console.WriteLine("Now the error trial!");

                // try block  
                try
                {
                    // Create the command to execute! With the wrong name of the table (Depends on your Database tables)  
                    SqlCommand errorCommand = new SqlCommand("SELECT * FROM someErrorColumn", conn);
                    // Execute the command, here the error will pop up!  
                    // But since we're catching the code block's errors, it will be displayed inside the console.  
                    errorCommand.ExecuteNonQuery();
                }
                // catch block  
                catch (SqlException er)
                {
                    // Since there is no such column as someErrorColumn (Depends on your Database tables)  
                    // SQL Server will throw an error.  
                    Console.WriteLine("There was an error reported by SQL Server, " + er.Message);
                }
            }
            // Final step, close the resources flush dispose them. ReadLine to prevent the console from closing.  
            Console.ReadLine();
        }

        public static void AddUser(UserModel user)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=AthenaeumDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn.Open();

                Console.WriteLine("INSERT INTO command");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Users ( Name, Notes) VALUES ( @1, @2)", conn);

                insertCommand.Parameters.Add(new SqlParameter("1", user.Name));
                insertCommand.Parameters.Add(new SqlParameter("2", user.Notes));

                Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());
                Console.WriteLine("Done! Press enter to move to the next step");
                Console.ReadLine();
                Console.Clear();
            }
        }


        public static void GetBooks()
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=AthenaeumDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM Books", conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Console.WriteLine("Id \t | Title \t | Author");
                    Console.WriteLine("--------------------------------------------");
                    while (reader.Read())
                    {
                        Console.WriteLine(String.Format("{0} \t | {1} \t | {2} ",
                        reader[0], reader[1], reader[2]));
                    }
                }
            }
        }
        public static void AddBook(BookModel book)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=DESKTOP-32N87F3\\MSSQLSERVER01;Database=AthenaeumDatabase;Trusted_Connection=True;MultipleActiveResultSets=true;";
                conn.Open();

                Console.WriteLine("INSERT INTO command");

                SqlCommand insertCommand = new SqlCommand("INSERT INTO Books ( Title, Author) VALUES ( @1, @2)", conn);

                insertCommand.Parameters.Add(new SqlParameter("1", book.Title));
                insertCommand.Parameters.Add(new SqlParameter("2", book.Author));

                Console.WriteLine("Commands executed! Total rows affected are " + insertCommand.ExecuteNonQuery());
                Console.WriteLine("Done! Press enter to move to the next step");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
