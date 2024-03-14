using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle(int length, int width)
        {
            this.length = Math.Max(1, length); 
            this.width = Math.Max(1, width);  
        }

        public int GetLength()
        {
            return length;
        }

        public void SetLength(int length)
        {
            if (length > 0)
            {
                this.length = length;
            }
            
        }

        public int GetWidth()
        {
            return width;
        }

        public void SetWidth(int width)
        {
            if (width > 0)
            {
                this.width = width;
            }
            
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
