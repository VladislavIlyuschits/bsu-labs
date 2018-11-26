using System;
using NUnit.Framework;

namespace Lab3.Tests
{
    [TestFixture]
    public class TriangleValidatorTests
    {
        [TestCase(1, 5, 3, false)]
        [TestCase(2, 2, 2, true)]
        [TestCase(6, 8, 10, true)]
        [TestCase(1, 1, 1, true)]
        [TestCase(1, 5, 4, false)]
        [TestCase(10, 9, 17, true)]
        [TestCase(3, 4, 5, true)]
        [TestCase(1, 43, 3, false)]
        [TestCase(10, 1, 1, false)]
        [TestCase(18, 47, 45, true)]
        public void TriangleValidatorValidateWithCorrectParameters_Bool_TriangleExistence(int a, int b, int c, bool expected)
        {
            Assert.AreEqual(TriangleValidator.Validate(a, b, c), expected);
        }

        [TestCase(0, 1, 1)]
        [TestCase(1, 0, 1)]
        [TestCase(1, 1, 0)]
        [TestCase(1, 1, -1)]
        [TestCase(1, -1, 1)]
        [TestCase(-1, 0, 1)]
        [TestCase(-1, -5, 1)]
        [TestCase(-1, 1, -5)]
        [TestCase(-1, -1, -1)]
        [TestCase(-1, 0, 0)]
        [TestCase(3, 4, -5)]
        [TestCase(6, -8, 10)]
        [TestCase(1, 5, -3)]
        [TestCase(6, 8, 0)]
        [TestCase(0, 0, 0)]
        public void TriangleValidatorValidateWithWrongParameters_Throws_ArgumentExeption(int a, int b, int c)
        {
            Assert.Throws<ArgumentException>(() => TriangleValidator.Validate(a, b, c));
        }
    }
}
