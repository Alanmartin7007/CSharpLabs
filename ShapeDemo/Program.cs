using System;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Threading.Channels;
using System.Transactions;

namespace ShapeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 for Circle , 2 Rectangle ,3 for Triangle,4 for Square,5 trapezium,6 Exit");
                Console.WriteLine("Select the Shape");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid value");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        HandleCircle();
                        break;
                    case 2:

                        HnadleRect();
                        break;
                    case 3:

                        HandleTri();
                        break;
                    case 4:
                        HnadleSqu();
                        break;
                    case 5:
                        handletrapi();
                        break;
                    case 6:
                        Console.WriteLine("Exit");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;


                }
            }
        }


    
    static void HandleCircle()
    {
        Console.WriteLine("Enter the Radius");
        string innput = Console.ReadLine();
        if (!double.TryParse(innput, out double radius))
        {
            Console.WriteLine("Invalid ");
            return;
        }
        Clircle circle1 = new Clircle(radius);
        double area = circle1.Area();
        Console.WriteLine($"Area of circle is :{area}");
    }

        static void HnadleRect()
        {
            Console.WriteLine("Enter the Length and Breadth");
            string inputn = Console.ReadLine();
            if (!double.TryParse(inputn, out double length))
            {
                Console.WriteLine("invalid ");
                return;

            }
            inputn = Console.ReadLine();
            if (!double.TryParse(inputn, out double breadth))
            {
                Console.WriteLine("invalid ");
                return;

            }
            Rectangle rec = new Rectangle(length, breadth);

            double a = rec.Area();
            if (length == breadth)
            {
                Console.WriteLine($" Area of Square :{a}");
            }
            else
            {
                Console.WriteLine($" Area of Rectangle :{a}");
            }
        }
        static void HnadleSqu()
        {
            Console.WriteLine("Enter the Side");
            string inputn = Console.ReadLine();
            if (!double.TryParse(inputn, out double length))
            {
                Console.WriteLine("invalid ");
                return;

            }
           
            Rectangle rec = new Rectangle(length, length);

            double a = rec.Area();
           
                Console.WriteLine($" Area of Square :{a}");
           
               
        }
        static void HandleTri()
        {
            Console.WriteLine("Enter the Height and Base");
            string input= Console.ReadLine();
            if (!double.TryParse(input, out double height))
            {
                Console.WriteLine("Invalid ");
            }
            input=Console.ReadLine();
            if (!double.TryParse(input, out double breadth))
            {
                Console.WriteLine("Invalid ");
            }
            Triangle tri=new Triangle(height, breadth);
            double area =tri.Area();
            Console.WriteLine($"Area of Triangle {area}");
        }
        static void handletrapi()
        {
            Console.WriteLine("Enter the parallel sides and Base");
            string input = Console.ReadLine();
            if (!double.TryParse(input, out double height))
            {
                Console.WriteLine("Invalid ");
            }
            input = Console.ReadLine();
            if (!double.TryParse(input, out double breadth))
            {
                Console.WriteLine("Invalid ");
            }
            input = Console.ReadLine();
            if (!double.TryParse(input, out double parallel))
            {
                Console.WriteLine("Invalid ");
            }
            Trapezium tra = new Trapezium(height, breadth,parallel);
            double area = tra.Area();
            Console.WriteLine($"Area of Triangle {area}");
        }
    }
}
