using System;

namespace Assignment2
{
    /// Assignment 2 a rectangle with a length and width.
    public class Rectangle
    {
        /// The length of the rectangle.
        private int length;

        /// The width of the rectangle.
        private int width;

        /// Initializes a new instance of the Rectangle class with a default length and width of 1.
        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        /// Initializes a new instance of the Rectangle class with the specified length and width.
        /// <param name="length">The length of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        public Rectangle(int length, int width)
        {
            if (length > 0 && width > 0)
            {
                this.length = length;
                this.width = width;
            }
            else
            {   /// <exception cref="ArgumentException">Thrown when either length or width is less than or equal to 0.</exception>
                throw new ArgumentException("Length and width must be greater than 0.");
            }
        }

        /// Gets the length of the rectangle.
        public int GetLength()
        {
            return length;
        }

        public void SetLength(int newLength)
        {
            // Check if the length is within the valid range
            if (newLength < 0 || newLength > 1100)
            {
                throw new ArgumentOutOfRangeException(nameof(newLength), "The length must be between 0 and 1100.");
            }

            // Set the length
            length = newLength;
        }

        public void SetWidth(int width)
        {
            if (width > 0 && width <= 1100)
            {
                this.width = width;
            }
            else
            {
                /// <exception cref="ArgumentOutOfRangeException">Thrown when width is less than or equal to 0 or greater than 1100.</exception>
                throw new ArgumentOutOfRangeException("Width must be greater than 0 and less than or equal to 1100.");
            }
        }

        /// Gets the width of the rectangle.
        public int GetWidth()
        {
            return width;   /// <returns>The width of the rectangle.</returns>

        }

        /// Gets the perimeter of the rectangle.
        public int GetPerimeter()
        {
            // Calculate the perimeter
            int perimeter = 2 * (length + width);

            // Ensure that the returned value is non-negative
            if (perimeter < 0)
            {
                throw new InvalidOperationException("The perimeter cannot be negative.");
            }

            return perimeter;
        }


        public int GetArea()
        {
            // Calculate the area
            int area = length * width;

            // Ensure that the returned value is non-negative
            if (area < 0)
            {
                throw new InvalidOperationException("The area cannot be negative.");
            }

            return area;
        }
    }
    }