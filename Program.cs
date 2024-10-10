using System;
using System.Collections.Generic;

namespace Lab_7 {
    public class TableReservationApp {
        static void Main(string[] args)
        {
            ReservationManagerClass m = new ReservationManagerClass();
            m.AddRestaurantMethod("A", 10);
            m.AddRestaurantMethod("B", 5);

            Console.WriteLine(m.BookTable("A", new DateTime(2023, 12, 25), 3)); // True
            Console.WriteLine(m.BookTable("A", new DateTime(2023, 12, 25), 3)); // False
        }
    }
}
public class TableReservationApp
{
    static void Main(string[] args)
    {
        ReservationManagerClass m = new ReservationManagerClass();
        m.AddRestaurantMethod("A", 10);
        m.AddRestaurantMethod("B", 5);

        Console.WriteLine(m.BookTable("A", new DateTime(2023, 12, 25), 3)); // True
        Console.WriteLine(m.BookTable("A", new DateTime(2023, 12, 25), 3)); // False
    }
}