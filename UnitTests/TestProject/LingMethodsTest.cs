using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqMethod;
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
       
        public void ShouldReturnIndex()
        {
            //Arrange
            string[] arr1 = new string[4] { "cat", "dog", "cow", "tiger" };
            string filter = "tiger";
            string expectedOutput = "tiger";
            
            LinqMethods foo = new LinqMethods();
            //Act
            var result = foo.LinqMethod5(arr1, filter);
            Assert.AreEqual(expectedOutput, result);
            //Buildet alles in der Projektmappe Shortcut: Strg, Shift, B
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
            Assert.IsTrue(result.All(e => expectedList.Contains(e)));
        }
       
        public void ShouldReturnNumbersInAscendingOrder()
        {
            //Arrange
            List<int> startingList = new List<int>() {1, 4, 3, 2, 6, 5, 9, 8, 7, 12, 10, 11 };
            List<int> expectedList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            LinqMethods baaaa = new LinqMethods();
            //Act
            var result = baaaa.LinqMethod7(startingList);

            //Assert
            CollectionAssert.AreEqual(expectedList, result);
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
        [TestMethod]
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
            List<string> expectedListOfString = new List<string>() { "m", "n", "o", "p" };
            LinqMethods foooo = new LinqMethods();
            //Act
            var result = foooo.LinqMethod10(listOfString)

        }


    }
}