using System;

namespace Assignment2
{
    /// Represents a rectangle with a length and width.
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
            {
                throw new ArgumentException("Length and width must be greater than 0.");
                /// <exception cref="ArgumentException">Thrown when either length or width is less than or equal to 0.</exception>

            }
        }


        /// Gets the length of the rectangle.

        public int GetLength()
        {
            /// <returns>The length of the rectangle.</returns>

            return length;
        }


        /// Sets the length of the rectangle.
        /// <param name="length">The new length of the rectangle.</param>
        public void SetLength(int length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            else
            {
                throw new ArgumentException("Length must be greater than 0.");
                /// <exception cref="ArgumentException">Thrown when length is less than or equal to 0.</exception>

            }
        }


        /// Gets the width of the rectangle.
        public int GetWidth()
        {
            /// <returns>The width of the rectangle.</returns>

            return width;
        }

        /// Sets the width of the rectangle.

        /// <param name="width">The new width of the rectangle.</param>
        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            else
            {
                throw new ArgumentException("Width must be greater than 0.");
                /// <exception cref="ArgumentException">Thrown when width is less than or equal to 0.</exception>

            }
        }


        /// Gets the perimeter of the rectangle.

        public int GetPerimeter()
        {
            /// <returns>The perimeter of the rectangle.</returns>

            return 2 * (length + width);

        }


        /// Gets the area of the rectangle.

        public int GetArea()

        {
            /// <returns>The area of the rectangle.</returns>

            return length * width;
        }
    }
}