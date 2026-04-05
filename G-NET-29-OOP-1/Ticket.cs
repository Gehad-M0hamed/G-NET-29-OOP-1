using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_29_OOP_1
{
   
        public class Ticket
        {
            public string MovieName;
            public TicketType Type;
            public SeatLocation Seat;
            private double Price;

            public Ticket(string movieName, TicketType type, SeatLocation seat, double price)
            {
                MovieName = movieName;
                Type = type;
                Seat = seat;
                Price = price;
            }

            public Ticket(string movieName)
                : this(movieName, TicketType.Standard, new SeatLocation('A', 1), 50)
            {
            }

            public double CalcTotal(double taxPercent)
            {
                return Price + (Price * taxPercent / 100);
            }

            public void ApplyDiscount(ref double discountAmount)
            {
                if (discountAmount > 0 && discountAmount <= Price)
                {
                    Price -= discountAmount;
                    discountAmount = 0;
                }
            }

            public void PrintTicket()
            {
               Console.WriteLine($"Movie: {MovieName}");
               Console.WriteLine($"Type: {Type}");
               Console.WriteLine($"Seat: {Seat}");
               Console.WriteLine($"Price: {Price:F2}");
            }
        }
    
}
