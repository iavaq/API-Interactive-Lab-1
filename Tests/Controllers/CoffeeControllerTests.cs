using API_Interactive_Lab_1.Controllers;
using API_Interactive_Lab_1.Models;
using NUnit.Framework;
namespace API_Interactive_Lab1.Tests
{
    public class CoffeeControllerTests
    {

        [Test]
        public void TestGetLover()
        {
            //ARRANGE
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();

            //ACT
            var result = controller.GetLover();

            //ASSERT
            Assert.AreEqual(expectedContent, result);

        }

        [Test]
        public void TestGetCoffeeNoParams()
        {
            //ARRANGE
            Coffee expected = new Coffee { Name = "latte", Id = -1 };
            var controller = new CoffeeController();

            //ACT
            var result = controller.Get(null);

            //ASSERT
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);

        }

        [Test]
        public void TestGetCoffeeByName()
        {
            //ARRANGE
            string name = "americano";
            Coffee expected = new Coffee { Name = name, Id = 2 };
            var controller = new CoffeeController();

            //ACT
            var result = controller.Get(name);

            //ASSERT
            //ASSERT
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);

        }

    }
}
