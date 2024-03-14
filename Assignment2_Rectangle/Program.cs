using System;
using Assignment2;

internal class Program
{
    public static void Main(string[] args)
    {
        // Create a new rectangle with default length and width of 1
        var rectangle = new Rectangle();

        // Display information about the default rectangle
        DisplayRectangleInfo("Default Rectangle", rectangle);

        // Prompt the user to enter dimensions for a new rectangle
        Console.WriteLine("\nEnter dimensions for a new rectangle:");

        // Prompt the user to enter the length
        Console.Write("Enter length: ");
        int userLength = Convert.ToInt32(Console.ReadLine());

        // Set the length of the rectangle
        rectangle.SetLength(userLength);

        // Prompt the user to enter the width
        Console.Write("Enter width: ");
        int userWidth = Convert.ToInt32(Console.ReadLine());

        // Set the width of the rectangle
        rectangle.SetWidth(userWidth);

        // Display information about the user-defined rectangle
        DisplayRectangleInfo("User Rectangle", rectangle);
    }

    static void DisplayRectangleInfo(string title, Rectangle rectangle)
    {
        // Display the title
        Console.WriteLine($"\n{title} - Length: {rectangle.GetLength()}, Width: {rectangle.GetWidth()}");

        // Display the perimeter and area of the rectangle
        Console.WriteLine($"Perimeter: {rectangle.GetPerimeter()}, Area: {rectangle.GetArea()}");
    }
}