using NUnit.Framework;

namespace Assignment2.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        private Rectangle _rectangle = null;

        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        [Test]
        public void DefaultConstructor_LengthAndWidthSetToOne()
        {
            Assert.AreEqual(1, _rectangle.GetLength());
            Assert.AreEqual(1, _rectangle.GetWidth());
        }

        [Test]
        public void ParameterizedConstructor_LengthAndWidthSetCorrectly()
        {
            int length = 5;
            int width = 8;
            var rectangle = new Rectangle(length, width);

            Assert.AreEqual(length, rectangle.GetLength());
            Assert.AreEqual(width, rectangle.GetWidth());
        }

        [Test]
        public void SetLength_ValidValue_LengthUpdated()
        {
            int newLength = 10;
            _rectangle.SetLength(newLength);

            Assert.AreEqual(newLength, _rectangle.GetLength());
        }

        [Test]
        public void SetWidth_ValidValue_WidthUpdated()
        {
            int newWidth = 7;
            _rectangle.SetWidth(newWidth);

            Assert.AreEqual(newWidth, _rectangle.GetWidth());
        }

        [Test]
        public void GetPerimeter_ValidValues_CorrectPerimeterCalculated()
        {
            int length = 3;
            int width = 4;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            int perimeter = _rectangle.GetPerimeter();

            Assert.AreEqual(2 * (length + width), perimeter);
        }

        [Test]
        public void GetArea_ValidValues_CorrectAreaCalculated()
        {
            int length = 5;
            int width = 6;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            int area = _rectangle.GetArea();

            Assert.AreEqual(length * width, area);
        }

       

        // GetLength Tests
        [Test]
        public void GetLength_AfterSettingNewLength_ReturnsUpdatedLength()
        {
            _rectangle.SetLength(15);
            Assert.AreEqual(15, _rectangle.GetLength());
        }

        [Test]
        public void GetLength_UsingParameterizedConstructor_ReturnsInitialLength()
        {
            var customRectangle = new Rectangle(20, 10);
            Assert.AreEqual(20, customRectangle.GetLength());
        }

        // SetLength Tests
        [Test]
        public void SetLength_ToZero_LengthUnchanged()
        {
            _rectangle.SetLength(0);
            Assert.AreNotEqual(0, _rectangle.GetLength());
        }

        [Test]
        public void SetLength_NegativeValue_LengthUnchanged()
        {
            _rectangle.SetLength(-5);
            Assert.AreNotEqual(-5, _rectangle.GetLength());
        }

        // GetWidth Tests
        [Test]
        public void GetWidth_AfterSettingNewWidth_ReturnsUpdatedWidth()
        {
            _rectangle.SetWidth(12);
            Assert.AreEqual(12, _rectangle.GetWidth());
        }

        [Test]
        public void GetWidth_UsingParameterizedConstructor_ReturnsInitialWidth()
        {
            var customRectangle = new Rectangle(10, 25);
            Assert.AreEqual(25, customRectangle.GetWidth());
        }

        // SetWidth Tests
        [Test]
        public void SetWidth_ToZero_WidthUnchanged()
        {
            _rectangle.SetWidth(0);
            Assert.AreNotEqual(0, _rectangle.GetWidth());
        }

        [Test]
        public void SetWidth_NegativeValue_WidthUnchanged()
        {
            _rectangle.SetWidth(-10);
            Assert.AreNotEqual(-10, _rectangle.GetWidth());
        }

        // GetPerimeter Tests
        [Test]
        public void GetPerimeter_WithZeroLengthOrWidth_ReturnsZeroOrPositiveValue()
        {
            _rectangle.SetLength(0);
            _rectangle.SetWidth(5);
            Assert.IsTrue(_rectangle.GetPerimeter() >= 0);
        }

        [Test]
        public void GetPerimeter_WithNegativeValues_ReturnsPositiveOrCorrectedValue()
        {
            _rectangle.SetLength(-3);
            _rectangle.SetWidth(4);
            Assert.IsTrue(_rectangle.GetPerimeter() > 0);
        }
        //getarea
        [Test]
        public void GetArea_WithLengthFiveAndWidthTwo_ReturnsTen()
        {
            // Arrange
            _rectangle.SetLength(5);
            _rectangle.SetWidth(2);

            // Act & Assert
            Assert.AreEqual(10, _rectangle.GetArea());
        }

        [Test]
        public void GetArea_WithLengthOneAndWidthOne_ReturnsOne()
        {
            // Act & Assert
            Assert.AreEqual(1, _rectangle.GetArea());
        }

        [Test]
        public void GetArea_WithMaximumIntForLengthAndOneForWidth_ReturnsMaximumInt()
        {
            // Arrange
            _rectangle.SetLength(int.MaxValue);
            _rectangle.SetWidth(1);

            // Act & Assert
            Assert.AreEqual(int.MaxValue, _rectangle.GetArea());
        }
    }
}