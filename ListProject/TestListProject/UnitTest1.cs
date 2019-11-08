using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ListProject;
namespace TestListProject
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void CustomList_Add_AddOneIntToListUpCount()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int expected = 1;
        //    int actual;
        //    int number1 = 1;

        //    //act
        //    list1.Add(number1);
        //    actual = list1.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}


        //[TestMethod]
        //public void CustomList_Add_AddValuesAndCheckIndexOfThirdAddedValue()
        //{
        //    //arrange
        //    CustomList<string> list1 = new CustomList<string>();
        //    string first = "Carolynn";
        //    string second = "Carter";
        //    string third = "Jackson";
        //    string expected = "Jackson";
        //    string actual;

        //    // act
        //    list1.Add(first);
        //    list1.Add(second);
        //    list1.Add(third);
        //    actual = list1[2];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CustomList_Add_AddValuesResizeArray()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;
        //    int actual;
        //    int expected = 5;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    actual = list1.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Add_CheckIndexAtCapacity()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;
        //    int actual;
        //    int expected = 5;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    actual = list1[4];

        //    //assert
        //    Assert.AreEqual(expected, actual);

        //}
        //[TestMethod]
        //public void CustomList_Add_CheckCapacity()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int expected = 8;
        //    int actual;
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    actual = list1.Capacity;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_RemoveOneIntCountDecrease()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int expected = 3;
        //    int actual;
        //    int number1 = 1;
        //    int number2 = 2;
        //    int number3 = 3;
        //    int number4 = 4;

        //    //act
        //    list1.Add(number1);
        //    list1.Add(number2);
        //    list1.Add(number3);
        //    list1.Add(number4);
        //    list1.Remove(number2);
        //    actual = list1.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_RemoveValuesAndCheckIndexOne()
        //{
        //    //arrange
        //    CustomList<string> list1 = new CustomList<string>();
        //    string first = "Carolynn";
        //    string second = "Carter";
        //    string third = "Jackson";
        //    string expected = "Jackson";
        //    string actual;

        //    // act
        //    list1.Add(first);
        //    list1.Add(second);
        //    list1.Add(third);
        //    list1.Remove(first);
        //    actual = list1[1];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_RemoveValuesResizeArrayDown()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;
        //    int actual;
        //    int expected = 4;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    list1.Remove(num1);
        //    actual = list1.Count;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_CheckIndexAtCapacityOnceCapacityIsLowered()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;
        //    int actual;
        //    int expected = 5;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    list1.Remove(num4);
        //    actual = list1[3];

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_CheckCapacity()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int expected = 8;
        //    int actual;
        //    int num1 = 1;
        //    int num2 = 2;
        //    int num3 = 3;
        //    int num4 = 4;
        //    int num5 = 5;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Add(num3);
        //    list1.Add(num4);
        //    list1.Add(num5);
        //    list1.Remove(num2);
        //    actual = list1.Capacity;

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Remove_BoolToCheckNumWasRemoved()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    bool actual;
        //    bool expected = true;
        //    int num1 = 1;
        //    int num2 = 2;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    list1.Remove(num1);
        //    list1.Remove(num2);
        //    actual = (list1[1] == 0);

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_ToString_IntToString()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    int num1 = 1;
        //    string expected = "1";
        //    string actual;

        //    //act
        //    list1.Add(num1);
        //    actual = list1.ToString();

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_ToString_DoubleToString()
        //{
        //    //arrange
        //    CustomList<double> list1 = new CustomList<double>();
        //    double num1 = 10.25;
        //    double num2 = 20.00;
        //    string expected = "10.2520";
        //    string actual;

        //    //act
        //    list1.Add(num1);
        //    list1.Add(num2);
        //    actual = list1.ToString();

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_ToString_CharToString()
        //{
        //    //arrange
        //    CustomList<char> list1 = new CustomList<char>();
        //    char c = 'c';
        //    char a = 'a';
        //    char r = 'r';
        //    string expected = "car";
        //    string actual;

        //    //act
        //    list1.Add(c);
        //    list1.Add(a);
        //    list1.Add(r);
        //    actual = list1.ToString();

        //    //assert
        //    Assert.AreEqual(expected, actual);
        //}
        //[TestMethod]
        //public void CustomList_Plus_OverloadPlusOperator()
        //{
        //    //arrange
        //    CustomList<int> list1 = new CustomList<int>();
        //    CustomList<int> list2 = new CustomList<int>();
        //    string expected = "135216";            

        //    //act
        //    list1.Add(1);
        //    list1.Add(3);
        //    list1.Add(5);
        //    list2.Add(2);
        //    list2.Add(1);
        //    list2.Add(6);
        //    CustomList<int> actual = list1 + list2;

        //    //assert
        //    Assert.AreEqual(expected, actual.ToString());
        //}
        [TestMethod]
        public void CustomList_Subtract_OverloadSubtractOperator()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "35";

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(1);
            list2.Add(6);
            CustomList<int> actual = list1 - list2;

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void CustomList_Zip_ZipOverTwoLists()
        {
            //arrange
            CustomList<int> list1 = new CustomList<int>();
            CustomList<int> list2 = new CustomList<int>();
            string expected = "123456";

            //act
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);
            

            //assert
            Assert.AreEqual(expected, actual.ToString());
        }

    }
}
