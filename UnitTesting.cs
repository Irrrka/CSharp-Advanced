using System;
using ListIterator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ListIeratorClass
{
    [TestClass]
    public class ListIteratorClassTest
    {
        private ListIteratorClass listIteratorClass;

        [TestInitialize]
        public void Init()
        {
            this.listIteratorClass = new ListIteratorClass();
        }

        [TestMethod]
        public void ConstructorShouldInitializeCollectionWithAGivenNonEmptyCollection()
        {
            List < string > expected= new List<string>() { "Pesho", "Stamat", "George"};
            this.listIteratorClass = new ListIteratorClass(expected);
            CollectionAssert.AreEqual(expected, this.listIteratorClass.Collection, "Collections are not equal");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorShouldNOTInitializeCollectionWithoutAGivenEmptyCollection()
        {
            List<string> expected = new List<string>();
            this.listIteratorClass = new ListIteratorClass(expected);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConstructorShouldNOTInitializeCollectionWithNull()
        {
            List<string> expected = null;
            this.listIteratorClass = new ListIteratorClass(expected);
        }

        [TestMethod]
        public void MoveWithTwoElementsShouldReturnTrue()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat"};
            this.listIteratorClass = new ListIteratorClass(expected);
            bool hasMoved = this.listIteratorClass.Move();
            Assert.IsTrue(hasMoved);
        }

        [TestMethod]
        public void MoveWithTwoElementsShouldReturnFalseWithDoubleMoves()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat" };
            this.listIteratorClass = new ListIteratorClass(expected);
            this.listIteratorClass.Move();
            bool hasMoved = this.listIteratorClass.Move();
            Assert.IsFalse(hasMoved);
        }

        [TestMethod]
        public void OneMoveShouldReturnIndexWithOne()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat" };
            this.listIteratorClass = new ListIteratorClass(expected);
            int beforeMove = this.listIteratorClass.CurrIndex;
            this.listIteratorClass.Move();
            int afterMove = this.listIteratorClass.CurrIndex;
            Assert.AreEqual(0, beforeMove);
            Assert.AreEqual(1, afterMove);
        }

        [TestMethod]
        public void HasNextWithNoMoveWithTwoElementsShouldReturnTrue()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat" };
            this.listIteratorClass = new ListIteratorClass(expected);
            bool hasNext = this.listIteratorClass.HasNext();
            Assert.IsTrue(hasNext);
        }
        [TestMethod]
        public void HasNextWithOneMoveWithTwoElementsShouldReturnFalse()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat" };
            this.listIteratorClass = new ListIteratorClass(expected);
            this.listIteratorClass.Move();
            bool hasNext = this.listIteratorClass.HasNext();
            Assert.IsFalse(hasNext);
        }
        [TestMethod]
        public void PrintWithNoMoveShouldReturnOthElement()
        {
            List<string> expected = new List<string>() { "Pesho", "Stamat" };
            this.listIteratorClass = new ListIteratorClass(expected);
            string result = this.listIteratorClass.Print();
            Assert.AreEqual(expected[0],result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void PrintWithEmptyCollShouldThrow()
        {
            List<string> expected = new List<string>();
            this.listIteratorClass = new ListIteratorClass(expected);
            string result = this.listIteratorClass.Print();
        }

    }
}
