using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqMethod;
using FluentAssertions;
namespace TestProject
{
    

    [TestClass]
    public class LinqTests
    {
        [TestMethod]
        public void ShouldShowEvenNumbers()
        {
            //Arrange
            List<int> startingList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            List<int> expectedList = new List<int>() { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18};
            LinqMethods list = new LinqMethods();
            //Act
             var result = list.LinqMethod1(startingList);
            //Assert
            Assert.IsTrue(result.All(e=> expectedList.Contains(e)));
        }
        
        public void ShouldShowCityWithCondition()
        {
            //Arrange
            List<string> cities = new List<string>() { "Rome", "London", "Nairobi", "California", "Zurich", "New Dehli", "Amsterdam", "Paris", "Abu Dhabi" };
            List<string> expectedCities = new List<string>() { "Zurich" };
            LinqMethods list2 = list2 = new LinqMethods();
            //Act
            var result = list2.LinqMethod2(cities);
            //Assert
            //Both works
            //Assert.IsTrue(result.All(e=> expectedCities.Contains(e)));
            Assert.AreEqual(result[0], expectedCities[0]);
        }
      
        public void ShoulReturnWordToUpper()
        {
            //Arrange
            string value = "Hallo WIE geht es DIR?";
            string[] expectedUserInput = {"WIE", "DIR?"};
            LinqMethods list3 = new LinqMethods();

            //Act
            var result = list3.LinqMethod3(value);

            //Assert
            Assert.IsTrue(result.All(x => expectedUserInput.Contains(x)));
        }
        
        public void ShoulReturnCountOfEachChar()
        {
            //Arrange
            string value = "w3resource";
            string[] expectedValue = { "w:1", "3:1", "r:2", "e:2", "s:1", "o:1", "u:1", "c:1" };
            LinqMethods list4 = new LinqMethods();
            //Act
            var result = list4.LinqMethod4(value).ToArray();
            //Assert
            CollectionAssert.AreEqual(expectedValue, result);
        }
        [TestMethod]
        public void ShouldReturnIndex()
        {
            //Arrange
            string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };
            string filter = "tiger";
            string expectedOutput = "tiger";
            
            LinqMethods foo = new LinqMethods();
            //Act
            var result = foo.LinqMethod5(arr1, filter);
            //Assert
            //Assert.AreEqual(expectedOutput, result);
            //Buildet alles in der Projektmappe Shortcut: Strg, Shift, B
            result.Should().StartWith("tiger").And.ContainEquivalentOf(expectedOutput);
        }
       
        public void ShouldReturnOddNumber()
        {
            //Arrange
            List<int> startingList = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            List<int> expectedList = new List<int>() { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
            LinqMethods baa = new LinqMethods();

            //Act
            var result = baa.LinqMethod6(startingList);

            //Assert
            //CollectionAssert.AreEqual(expectedList, result);
            //or
            //Assert.IsTrue(result.All(e => expectedList.Contains(e)));
            //or(usingFluentAssertions)
            result.Should().HaveSameCount(expectedList).And.ContainInOrder(expectedList);

        }
        [TestMethod]
        public void ShouldReturnNumbersInAscendingOrder()
        {
            //Arrange
            List<int> startingList = new List<int>() {1, 4, 3, 2, 6, 5, 9, 8, 7, 12, 10, 11 };
            List<int> expectedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            LinqMethods baaaa = new LinqMethods();
            //Act
            var result = baaaa.LinqMethod7(startingList);

            //Assert
            //CollectionAssert.AreEqual(expectedList, result);
            //or if(using FluentAssertion) + many different versions
            result.Should().StartWith(1).And.ContainInOrder(expectedList).And.EndWith(12).And.BeInAscendingOrder().And.HaveSameCount(startingList);
        }
       
        public void ShouldReturnCountOfEachNumber()
        {
            //Arrange
            int[] startingArray = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            string[] expectedOutput = new string[] { "5:3", "9:2", "1:1", "2:2", "3:2", "7:3", "6:3", "8:1", "4:1"};
            LinqMethods fooo = new LinqMethods();

            //Act
            var result = fooo.LinqMethod8(startingArray);

            //Assert
            CollectionAssert.AreEqual(expectedOutput, result);
        }
     
        public void ShouldReturnAllNumbersGreaterThanCondition()
        {
            //Arrange
            List<int> startingList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 32, 15, 30, 40, 70, 89 };
            int inputCondition = 5;
            List<int> expectedList = new List<int>() { 6, 7, 8, 32, 15, 30, 40, 70, 89 };
            LinqMethods foooo = new LinqMethods();

            //Act
            var result = foooo.LinqMethod9(startingList, inputCondition);

            //Assert

            CollectionAssert.AreEqual(expectedList, result);
            //or
            //Assert.IsTrue(result.All(x=> expectedList.Contains(x)));
        }
       
        public void ShouldReturnListWithCondition()
        {
            //Assert
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");
            //ArrayCount is 4
            List<string> expectedListOfString = new List<string>() { "m", "n", "o", "p" };
            LinqMethods foooo = new LinqMethods();
            //Act
            var result = foooo.LinqMethod10(listOfString);

            //Assert
            //CollectionAssert.AreEqual(expectedListOfString, result);
            //or (using FluentAssertions)
            result.Should().StartWith("m").And.Contain("n").And.Contain("o").And.EndWith("p").And.HaveCount(4);
            //or
            result.Should().ContainInOrder(expectedListOfString).And.HaveCount(4);

        }

        
        public void ShouldReturnNumberAndFrequency()
        {
            //Arrange
            int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };
            List<string> expectedOutput = new List<string>() { "5:3:15", "1:1:1", "9:1:9", "2:2:4", "3:2:6", "7:2:14", "4:2:8", "6:2:12", "8:1:8" };
            LinqMethods fo = new LinqMethods();

            //Act
            var result = fo.LinqMethod11(nums);

            //Assert
            //CollectionAssert.AreEqual(expectedOutput, result);
            //or
            //Assert.IsTrue(result.All(e => expectedOutput.Contains(e)));
            //or if(using FluentAssertions)
            result.Should().ContainInOrder(expectedOutput).And.HaveCount(9);

        }
    }
}