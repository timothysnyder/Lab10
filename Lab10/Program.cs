using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
            static int counter;
            static void Main(string[] args)
            {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\t\tRadius = a Straight Line from the Center, \n\t\tto the Circumference of a Circle or Sphere.");
            Console.ForegroundColor = ConsoleColor.White;
            bool repeat = true;
                {            
                    while (repeat)
                    {
                        Console.WriteLine("\t\t\n\nPlease enter the radius of your circle:");
                        {
                            Circle circle1 = new Circle();


                            circle1.Radius = double.Parse(Console.ReadLine());
                            circle1.Radius = 3.14;
                            double circumfrence = circle1.CalculateCircumfrence();

                            double area = circle1.CalculateArea();
                            string formattedCir = circle1.CalculateFormattedCircumfrence();
                            string formattedArea = circle1.CalculatedFormattedArea();
                        Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine($"\n{circumfrence} is the circumfrence of your Circle\n\n{formattedCir} is the formatted circumfrence of your Circle\n\n{area} is the area of your Circle\n\n{formattedArea} is the formatted area of your Circle");
                        Console.ForegroundColor = ConsoleColor.White;
                        counter++;

                        }
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\n\tWould you like to continue? (1) to Play again, or (2) to end");
                        string response = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (response == "2")
                        {
                            Console.WriteLine($"\n\t\tYou Calculated the Radius for {counter} Circles.\n\n\t\t\tThanks for Playing!\n");

                            break;
                        }
                    }
                }
            }
        }
    }

