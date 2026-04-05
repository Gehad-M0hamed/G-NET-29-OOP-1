using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;

namespace G_NET_29_OOP_1
{
    internal class Program
    {
        
            //Part 01 : 
            #region Q1 :
            //class: Reference Type,,is a blueprint.
            //struct: is a lightweight Value Type.
            //EX:
            // Struct Behavior
            //Point p1;
            //p1.X = 10;
            //Point p2 = p1;
            //p2.X = 99;        //p1.X=10

            //// Class Behavior 
            //Student s1 = new Student();
            //s1.Age = 20;
            //Student s2 = s1; 
            //s2.Age = 30; //s1.Age = 30;
            #endregion

            #region Q2:
            // Private: accessible within the class at theye registered,
            // and can not be accessed from outside.This is the default setting for class members.
            // Pubic:The member have access to any location within the application or other projects they view.
            //Ex:
            //class User
            //{
            //    public string userName; //Any part of the code can be accessed and modified.
            //    private string password; // It cannot be viewed or modified from outside the class for protection.
            //    public void SetPassword(string p)
            //    {
            //        password = p;
            //    }
            //}
            #endregion

            #region Q3:
            //*Create a new project and choose consol app.
            //*Add Project Reference, and check my Library project.
            //*At the top of your code, add using followed by lib name.
            //*make sure the class is Public.
            //*write the code.
            //*run the project.
            #endregion

            #region Q4:
            //It is a separate project  contains reusable custom classes and data types,
            //    and  does not have a Main method so, it cannot be run on its own.
            //*Reusability
            //* Organization
            //* Maintenance

            #endregion

            #region Part 02 :
        static void Main(string[] args)
              {
            Console.Write("Enter Movie Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Type (0:Standard, 1:VIP, 2:IMAX): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Enter Row (A, B, C): ");
            char row = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Enter Seat Number: ");
            int seatNum = int.Parse(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Enter Discount Amount: ");
            double discount = double.Parse(Console.ReadLine());

            Ticket userTicket = new Ticket(name, type, new SeatLocation(row, seatNum), price);

            Console.WriteLine("\n--- Ticket Info ---");
            userTicket.PrintTicket();
            Console.WriteLine($"Total with Tax: {userTicket.CalcTotal(14):F2}");

            Console.WriteLine("\n--- Applying Discount ---");
            userTicket.ApplyDiscount(ref discount);

            userTicket.PrintTicket();
            Console.WriteLine($"Total with Tax: {userTicket.CalcTotal(14):F2}");
            Console.WriteLine($"Remaining Discount: {discount}");

        }
            #endregion

       
    }
}
