using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListProject;
namespace TestListProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CustomList_Add_AddOneIntToListUpCount()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int expected = 1;
            int actual;
            int number1 = 1;

            //act
            list1.AddToList(number1);
            actual = list1.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
            

        [TestMethod]    
        public void CustomList_Add_AddValuesAndCheckIndexOfThirdAddedValue()
            {
            //arrange
            CustomList<string> list1 = new CustomList<string>();
            string first = "Carolynn";
            string second = "Carter";
            string third = "Jackson";
            string expected = "Jackson";
            string actual;

            //act
            list1.AddToList(first);
            list1.AddToList(second);
            list1.AddToList(third);
            actual = list1[2];

            //assert
            Assert.AreEqual(expected, actual);
            }
                 
        [TestMethod]   
        public void CustomList_Add_AddValuesResizeArray()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int actual;
            int expected = 5;

            //act
            list1.AddToList(num1);
            list1.AddToList(num2);
            list1.AddToList(num3);
            list1.AddToList(num4);
            list1.AddToList(num5);
            actual = list1.Count;

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomList_Add_CheckIndexAtCapacity()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;
            int actual;
            int expected = 5;

            //act
            list1.AddToList(num1);
            list1.AddToList(num2);
            list1.AddToList(num3);
            list1.AddToList(num4);
            list1.AddToList(num5);
            actual = list1[4];

            //assert
            Assert.AreEqual(expected, actual);

        }
        public void CustomList_Add_CheckCapacity()
        {
            //arrange
            int expected = 8;
            int actual;
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;
            int num5 = 5;

            //act
            list1.AddToList(num1);
            list1.AddToList(num2);
            list1.AddToList(num3);
            list1.AddToList(num4);
            list1.AddToList(num5);
            actual = list1.Capacity;

            //assert
            Assert.AreEqual(expected, actual);
        }


             
         
        
    }
}
