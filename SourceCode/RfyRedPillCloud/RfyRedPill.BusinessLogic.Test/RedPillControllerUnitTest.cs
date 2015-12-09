using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RfyRedPill.BusinessLogic.Model;

namespace RfyRedPill.BusinessLogic.Test
{
    [TestClass]
    public class RedPillControllerUnitTest
    {
        [TestMethod]
        public void ReverseWords()
        {           
            Assert.AreEqual
                ("123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890",
                RedPillController.ReverseWords
                ("098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321098765432109876543210987654321"));
            Assert.AreEqual("0", RedPillController.ReverseWords("0"));
            Assert.AreEqual("", RedPillController.ReverseWords(""));
            Assert.AreEqual("asdfghjkl qwertyuiop", RedPillController.ReverseWords("poiuytrewq lkjhgfdsa"));

        }

        [TestMethod]
        public void WhatShapeIsThis()
        {

            Assert.AreEqual(TriangleType.Error, RedPillController.WhatShapeIsThis(5, 1, 1));
            Assert.AreEqual(TriangleType.Error, RedPillController.WhatShapeIsThis(0, 1, 1));
            Assert.AreEqual(TriangleType.Equilateral, RedPillController.WhatShapeIsThis(1, 1, 1));
            Assert.AreEqual(TriangleType.Error, RedPillController.WhatShapeIsThis(1, 1, 2));
            Assert.AreEqual(TriangleType.Isosceles, RedPillController.WhatShapeIsThis(2, 1, 2));
            Assert.AreEqual(TriangleType.Scalene, RedPillController.WhatShapeIsThis(3, 4, 5));

        }

        [TestMethod]
        public void FibonacciNumber()
        {

            Assert.AreEqual(0, RedPillController.GetFibonacci(0));
            Assert.AreEqual(1, RedPillController.GetFibonacci(1));
            Assert.AreEqual(1, RedPillController.GetFibonacci(2));
            Assert.AreEqual(2, RedPillController.GetFibonacci(3));
            Assert.AreEqual(3, RedPillController.GetFibonacci(4));
            Assert.AreEqual(5, RedPillController.GetFibonacci(5));

        }
    }
}
