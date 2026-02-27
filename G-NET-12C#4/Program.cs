using System.Diagnostics;

namespace G_NET_12C_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!")




               #region Question1

            ///Q1
            /// STRING IN Immutable DON'T EDITING
            /// 
            #endregion
            #region Question 2
            ////q2
               Console.Write("Enter Age: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Enter Day (1-7): ");
                int day = int.Parse(Console.ReadLine());

                Console.Write("Student ID? (yes/no): ");
                string student = Console.ReadLine().ToLower();

                double price = 0;
                string breakdown = "";

                // Age pricing
                if (age < 5)
                {
                    price = 0;
                    breakdown += "Base Price: Free\n";
                }
                else if (age <= 12)
                {
                    price = 30;
                    breakdown += "Base Price: 30 LE\n";
                }
                else if (age <= 59)
                {
                    price = 50;
                    breakdown += "Base Price: 50 LE\n";
                }
                else
                {
                    price = 25;
                    breakdown += "Base Price: 25 LE\n";
                }

                // Weekend
                if (price > 0 && (day == 6 || day == 7))
                {
                    price += 10;
                    breakdown += "Weekend surcharge: +10 LE\n";
                }

                // Student discount
                if (price > 0 && student == "yes")
                {
                    double discount = price * 0.2;
                    price -= discount;
                    breakdown += "Student discount: -20%\n";
                }

                Console.WriteLine("\n--- Breakdown ---");
                Console.WriteLine(breakdown);
                Console.WriteLine("Final Price: " + price + " LE");
            }
        
        }


    }
