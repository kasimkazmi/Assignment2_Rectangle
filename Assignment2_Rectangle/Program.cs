using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2;

internal class Program
{
    public static void Main(string[] args)
    {
        
        var rectangle = new Rectangle();

        
        DisplayRectangleInfo("Default Rectangle", rectangle);

        
        Console.WriteLine("\nEnter dimensions for a new rectangle:");

        
        Console.Write("Enter length: ");
        int userLength = Convert.ToInt32(Console.ReadLine());
        rectangle.SetLength(userLength);


        Console.Write("Enter width: ");
        int userWidth = Convert.ToInt32(Console.ReadLine());
        rectangle.SetWidth(userWidth);


        
        DisplayRectangleInfo("User Rectangle", rectangle);
    }

    static void DisplayRectangleInfo(string title, Rectangle rectangle)
    {
        Console.WriteLine($"\n{title} - Length: {rectangle.GetLength()}, Width: {rectangle.GetWidth()}");
        Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}, Area: {rectangle.GetArea()}");
    }
}
