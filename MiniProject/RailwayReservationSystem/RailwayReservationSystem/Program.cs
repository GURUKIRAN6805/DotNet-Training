using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    class Program
    {
        static string connectionString = (@"data source=ICS-LT-BQ8Q4D3\SQLEXPRESS; initial catalog=RailwayReservationSystem;" + "user id=sa; password=Guru6805;");
        static void Main()
        {
            Console.WriteLine("Railway Reservation System");
            while (true)
            {
                Console.WriteLine("user or admin?");
                string role = Console.ReadLine().ToLower();
                if (role == "admin")
                {
                    AdminLogin();
                }
                else if (role == "user")
                {
                    UserLogin();
                }
                else
                {
                    Console.WriteLine("Invalid role. Please enter 'user' or 'admin'.");
                }
            }
        }
        static void AdminLogin()
        {
            Console.WriteLine("Enter username:");
            string username = Console.ReadLine();
            Console.WriteLine("Enter password:");
            string password = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admins WHERE username=@username AND password=@password", con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    Console.WriteLine("Login successful.");
                    AdminMenu();
                }
                else
                {
                    Console.WriteLine("Invalid credentials or not an admin.");
                }
            }
        }
        static void AdminMenu()
        {
            while (true)
            {
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. View Trains");
                Console.WriteLine("2. Add Train");
                Console.WriteLine("3. Revise Fare");
                Console.WriteLine("4. Change Train Status");
                Console.WriteLine("5. View All Bookings");
                Console.WriteLine("6. View All Cancellations");
                Console.WriteLine("7. Logout");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewTrains();
                        break;
                    case 2:
                        AddTrain();
                        break;
                    case 3:
                        ReviseFare();
                        break;
                    case 4:
                        ChangeTrainStatus();
                        break;
                    case 5:
                        ViewAllBookings();
                        break;
                    case 6:
                        ViewAllCancellations();
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        static void ViewTrains()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Trains", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Train No: {reader["tno"]}, Name: {reader["tname"]}, From: {reader["from"]}, To: {reader["dest"]}, Price: {reader["price"]}, Class: {reader["class_of_travel"]}, Status: {reader["train_status"]}, Seats Available: {reader["seats_available"]}");
                }
            }
        }
        static void AddTrain()
        {
            Console.WriteLine("Enter Train No:");
            int tno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Train Name:");
            string tname = Console.ReadLine();
            Console.WriteLine("Enter From:");
            string from = Console.ReadLine();
            Console.WriteLine("Enter To:");
            string to = Console.ReadLine();
            Console.WriteLine("Enter Price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Class of Travel:");
            string classOfTravel = Console.ReadLine();
            Console.WriteLine("Enter Train Status (active/inactive):");
            string trainStatus = Console.ReadLine();
            Console.WriteLine("Enter Seats Available:");
            int seatsAvailable = int.Parse(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Trains (tno, tname, [from], dest, price, class_of_travel, train_status, seats_available) VALUES (@tno, @tname, @from, @dest, @price, @class_of_travel, @train_status, @seats_available)", con);
                cmd.Parameters.AddWithValue("@tno", tno);
                cmd.Parameters.AddWithValue("@tname", tname);
                cmd.Parameters.AddWithValue("@from", from);
                cmd.Parameters.AddWithValue("@dest", to);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@class_of_travel", classOfTravel);
                cmd.Parameters.AddWithValue("@train_status", trainStatus);
                cmd.Parameters.AddWithValue("@seats_available", seatsAvailable);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Train added successfully.");
            }
        }

        static void ReviseFare()
        {
            Console.WriteLine("Enter Train No:");
            int tno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Price:");
            decimal newPrice = decimal.Parse(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Trains SET price=@price WHERE tno=@tno", con);
                cmd.Parameters.AddWithValue("@price", newPrice);
                cmd.Parameters.AddWithValue("@tno", tno);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Fare revised successfully.");
            }
        }
        static void ChangeTrainStatus()
        {
            Console.WriteLine("Enter Train No:");
            int tno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter New Status (active/inactive):");
            string newStatus = Console.ReadLine();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Trains SET train_status=@status WHERE tno=@tno", con);
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@tno", tno);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Train status changed successfully.");
            }
        }
        static void ViewAllBookings()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Bookings", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Booking ID: {reader["booking_id"]}, User ID: {reader["user_id"]}, Train No: {reader["tno"]}, Seats Booked: {reader["seats_booked"]}, Booking Date: {reader["booking_date"]}");
                }
            }
        }
        static void ViewAllCancellations()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Cancellations", con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"Cancellation ID: {reader["cancellation_id"]}, Booking ID: {reader["booking_id"]}, Seats Cancelled: {reader["seats_cancelled"]}, Cancellation Date: {reader["cancellation_date"]}");
                }
            }
        }
        static void UserLogin()
        {
            Console.WriteLine("Do you want to login or register?");
            string choice = Console.ReadLine().ToLower();
            if (choice == "login")
            {
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT user_id FROM Users WHERE username=@username AND password=@password", con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int userId = (int)result;
                        Console.WriteLine("Login successful.");
                        UserMenu(userId);
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials or user does not exist.");
                    }
                }
            }
            else if (choice == "register")
            {
                Console.WriteLine("Enter name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Users (name, username, password) VALUES (@name, @username, @password)", con);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Registration successful. You can now login.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter 'login' or 'register'.");
            }
        }
        static void UserMenu(int userId)
        {
            while (true)
            {
                Console.WriteLine("User Menu:");
                Console.WriteLine("1. View Trains");
                Console.WriteLine("2. Book Tickets");
                Console.WriteLine("3. Cancel Tickets");
                Console.WriteLine("4. Logout");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        ViewTrains();
                        break;
                    case 2:
                        BookTickets(userId);
                        break;
                    case 3:
                        CancelTickets(userId);
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
        static void BookTickets(int userId)
        {
            Console.WriteLine("Enter Train No:");
            int tno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Seats:");
            int seats = int.Parse(Console.ReadLine());
            if (seats > 3)
            {
                Console.WriteLine("You can only book a maximum of 3 seats.");
                return;
            }
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT seats_available FROM Trains WHERE tno=@tno AND train_status='active'", con);
                cmd.Parameters.AddWithValue("@tno", tno);
                object result = cmd.ExecuteScalar();
                if (result != null && (int)result >= seats)
                {
                    SqlCommand bookCmd = new SqlCommand("INSERT INTO Bookings (user_id, tno, seats_booked) VALUES (@user_id, @tno, @seats_booked)", con);
                    bookCmd.Parameters.AddWithValue("@user_id", userId);
                    bookCmd.Parameters.AddWithValue("@tno", tno);
                    bookCmd.Parameters.AddWithValue("@seats_booked", seats);
                    bookCmd.ExecuteNonQuery();
                    SqlCommand updateSeatsCmd = new SqlCommand("UPDATE Trains SET seats_available = seats_available - @seats WHERE tno=@tno", con);
                    updateSeatsCmd.Parameters.AddWithValue("@seats", seats);
                    updateSeatsCmd.Parameters.AddWithValue("@tno", tno);
                    updateSeatsCmd.ExecuteNonQuery();
                    Console.WriteLine("Tickets booked successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid train number or not enough seats available.");
                }
            }
        }
        static void CancelTickets(int userId)
        {
            Console.WriteLine("Enter Booking ID:");
            int bookingId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Seats to Cancel:");
            int seats = int.Parse(Console.ReadLine());
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT seats_booked FROM Bookings WHERE booking_id=@booking_id AND user_id=@user_id", con);
                cmd.Parameters.AddWithValue("@booking_id", bookingId);
                cmd.Parameters.AddWithValue("@user_id", userId);
                object result = cmd.ExecuteScalar();
                if (result != null && (int)result >= seats)
                {
                    SqlCommand cancelCmd = new SqlCommand("INSERT INTO Cancellations (booking_id, seats_cancelled) VALUES (@booking_id, @seats_cancelled)", con);
                    cancelCmd.Parameters.AddWithValue("@booking_id", bookingId);
                    cancelCmd.Parameters.AddWithValue("@seats_cancelled", seats);
                    cancelCmd.ExecuteNonQuery();
                    SqlCommand updateBookingCmd = new SqlCommand("UPDATE Bookings SET seats_booked = seats_booked - @seats WHERE booking_id=@booking_id", con);
                    updateBookingCmd.Parameters.AddWithValue("@seats", seats);
                    updateBookingCmd.Parameters.AddWithValue("@booking_id", bookingId);
                    updateBookingCmd.ExecuteNonQuery();
                    SqlCommand updateSeatsCmd = new SqlCommand("UPDATE Trains SET seats_available = seats_available + @seats WHERE tno=(SELECT tno FROM Bookings WHERE booking_id=@booking_id)", con);
                    updateSeatsCmd.Parameters.AddWithValue("@seats", seats);
                    updateSeatsCmd.Parameters.AddWithValue("@booking_id", bookingId);
                    updateSeatsCmd.ExecuteNonQuery();
                    Console.WriteLine("Tickets cancelled successfully. Refund will be initiated shortly.");
                }
                else
                {
                    Console.WriteLine("Invalid booking ID or not enough seats booked.");
                }
            }
        }
    }
}