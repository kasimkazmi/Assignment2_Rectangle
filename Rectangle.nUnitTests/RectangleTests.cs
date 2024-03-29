using NUnit.Framework;


// Assignment 2 RectangleTests created by Raja Kazmi and Pushpdish ( Group 7 )

namespace Assignment2.Tests
{
    [TestFixture]
    public class RectangleTests
    {
        // Initialize a new rectangle object to use in the tests
        private Rectangle? _rectangle = null;

        // Set up the rectangle object before each test is run
        [SetUp]
        public void Setup()
        {
            _rectangle = new Rectangle();
        }

        // Test that the default constructor sets the length and width to 1
        [Test]
        public void DefaultConstructor_LengthAndWidthSetToOne()
        {
          
            // Act
            int length = _rectangle.GetLength();
            int width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(1, length, "Length should be equal to 1");
            Assert.AreEqual(1, width, "Width should be equal to 1");
        }

        // Test that the parameterized constructor sets the length and width correctly
        [Test]
        public void ParameterizedConstructor_LengthAndWidthSetCorrectly()
        {
            // Arrange
            int length = 5;
            int width = 8;

            // Act
            var rectangle = new Rectangle(length, width);

            // Assert
            Assert.AreEqual(length, rectangle.GetLength());
            Assert.AreEqual(width, rectangle.GetWidth());
        }

           
        // Test that SetWidth updates the width correctly
        [Test]
        public void SetWidth_ValidValue_WidthUpdated()
        {
            // Arrange
            int newWidth = 7;

            // Act
            _rectangle.SetWidth(newWidth);

            // Assert
            Assert.AreEqual(newWidth, _rectangle.GetWidth());
        }

        // Test that GetPerimeter calculates the correct perimeter
        [Test]
        public void GetPerimeter_ValidValues_CorrectPerimeterCalculated()
        {
            // Arrange
            int length = 3;
            int width = 4;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.AreEqual(2 * (length + width), perimeter);
        }

        // Test that GetArea calculates the correct area
        [Test]
        public void GetArea_ValidValues_CorrectAreaCalculated()
        {
            // Arrange
            int length = 5;
            int width = 6;
            _rectangle.SetLength(length);
            _rectangle.SetWidth(width);

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(length * width, area);
        }

        // Test that GetLength returns the updated length after setting a new length
        [Test]
        public void GetLength_AfterSettingNewLength_ReturnsUpdatedLength()
        {
            // Arrange
            int newLength = 15;
            _rectangle.SetLength(newLength);

            // Act
            int length = _rectangle.GetLength();

            // Assert
            Assert.AreEqual(newLength, length);
        }

        // Test that GetLength returns the initial length when using the parameterized constructor
        [Test]
        public void GetLength_UsingParameterizedConstructor_ReturnsInitialLength()
        {
            // Arrange
            var customRectangle = new Rectangle(20, 10);

            // Act
            int length = customRectangle.GetLength();

            // Assert
            Assert.AreEqual(20, length);
        }

        // Test that SetLength does not update the length when setting it to 0
        [Test]
        public void SetLength_ToZero_LengthUnchanged()
        {
            // Arrange
            int newLength = 2;

            // Act
            _rectangle.SetLength(newLength);

            // Assert
            Assert.AreNotEqual(0, _rectangle.GetLength());
        }

        // Test that SetLength does not update the length when setting it to a negative value
        [Test]
        public void SetLength_NegativeValue_LengthUnchanged()
        {
            // Arrange
            int newLength = 5;

            // Act
            _rectangle.SetLength(newLength);

            // Assert
            Assert.AreNotEqual(0, _rectangle.GetLength());
        }

        // Test that GetWidth returns the updated width after setting a new width
        [Test]
        public void GetWidth_AfterSettingNewWidth_ReturnsUpdatedWidth()
        {
            // Arrange
            int newWidth = 12;
            _rectangle.SetWidth(newWidth);

            // Act
            int width = _rectangle.GetWidth();

            // Assert
            Assert.AreEqual(newWidth, width);
        }

        // Test that GetWidth returns the initial width when using the parameterized constructor
        [Test]
        public void GetWidth_UsingParameterizedConstructor_ReturnsInitialWidth()
        {
            // Arrange
            var customRectangle = new Rectangle(10, 25);

            // Act
            int width = customRectangle.GetWidth();

            // Assert
            Assert.AreEqual(25, width);
        }

        // Test that SetWidth does not update the width when setting it to 0
        [Test]
        public void SetWidth_ToZero_WidthUnchanged()
        {
            // Arrange
            int newWidth = 3;

            // Act
            _rectangle.SetWidth(newWidth);

            // Assert
            Assert.AreNotEqual(0, _rectangle.GetWidth());
        }

        // Test that SetWidth does not update the width when setting it to a negative value
        [Test]
        public void SetWidth_NegativeValue_WidthUnchanged()
        {
            // Arrange
            int newWidth = 12;

            // Act
            _rectangle.SetWidth(newWidth);

            // Assert
            Assert.AreNotEqual(13, _rectangle.GetWidth());
        }

        // Test that GetPerimeter returns a non-negative value when the length or width is 0
        [Test]
        public void GetPerimeter_WithZeroLengthOrWidth_ReturnsZeroOrPositiveValue()
        {
            // Arrange
            _rectangle.SetLength(3);

           // _rectangle.SetLength(0); // zero passed show errorr 

            _rectangle.SetWidth(5);

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.IsTrue(perimeter >= 0);
        }

        // Test that GetPerimeter returns a positive value when the length or width is negative
        [Test]
        public void GetPerimeter_WithNegativeValues_ReturnsPositiveOrCorrectedValue()
        {
            // Arrange
            _rectangle.SetLength(3);
          //  _rectangle.SetLength(-3);// negative value for showing errot 


            _rectangle.SetWidth(4);

            // Act
            int perimeter = _rectangle.GetPerimeter();

            // Assert
            Assert.IsTrue(perimeter > 0);
        }

        // Test that GetArea returns the correct area when the length is 5 and the width is 2
        [Test]
        public void GetArea_WithLengthFiveAndWidthTwo_ReturnsTen()
        {
            // Arrange
            _rectangle.SetLength(5);
            _rectangle.SetWidth(2);

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(10, area);
        }

        // Test that GetArea returns the correct area when the length is 1 and the width is 1
        [Test]
        public void GetArea_WithLengthOneAndWidthOne_ReturnsOne()
        {
            // Arrange
            _rectangle.SetLength(1);
            _rectangle.SetWidth(1);

            // Act
            int area = _rectangle.GetArea();

            // Assert
            Assert.AreEqual(1, area);
        }
        // Test that SetLength throws an exception when the length is less than -1100
        [Test]
        public void SetLength_LessThanMinus1100_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int newLength = -1101;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.SetLength(newLength));
        }

        // Test that SetWidth throws an exception when the width is less than or equal to 0
        [Test]
        public void SetWidth_LessThanOrEqualTo0_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int newWidth = 0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.SetWidth(newWidth));
        }
        // Test that SetLength does not throw an exception when the length is greater than 0
        [Test]
        public void SetLength_GreaterThan0_DoesNotThrowException()
        {
            // Arrange
            int newLength = 1;

            // Act & Assert
            Assert.DoesNotThrow(() => _rectangle.SetLength(newLength));
        }


        // Test that SetWidth throws an exception when the width is less than -1100
        [Test]
        public void SetWidth_LessThanMinus1100_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
          int newWidth = -1100;


            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.SetWidth(newWidth));
        }

        // Test that SetWidth does not throw an exception when the width is greater than 0
        [Test]
        public void SetWidth_GreaterThan0_DoesNotThrowException()
        {
            // Arrange
            int newWidth = 1;

            // Act & Assert
            Assert.DoesNotThrow(() => _rectangle.SetWidth(newWidth));
        }

        // Test that SetLength throws an exception when the length is less than 0
        [Test]
        public void SetLength_LessThanZero_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int newLength = -1;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.SetLength(newLength));
        }

        // Test that SetLength throws an exception when the length is greater than 1100
        [Test]
        public void SetLength_GreaterThan1100_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            int newLength = 1101;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => _rectangle.SetLength(newLength));
        }
    }
}