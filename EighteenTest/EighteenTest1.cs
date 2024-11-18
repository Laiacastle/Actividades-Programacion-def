using activitiesUtils;
namespace EighteenTest
{
    [TestClass]
    public class EighteenTest1
    {
        [TestMethod]
        public void Interval0()
        {
            //Arrange
            int num = 0;
            //Act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero true
        }
        [TestMethod]
        public void Interval119()
        {
            //Arrange
            int num = 119;
            //Act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero true
        }
        [TestMethod]
        public void Interval121()
        {
            //Arrange
            int num = 121;
            //Act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(result); //Espero false
        }
        [TestMethod]
        public void IntervalNegative()
        {
            //Arrange
            int num = -1;
            //Act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(result); //Espero false
        }
        [TestMethod]
        public void Interval1()
        {
            //Arrange
            int num = 1;
            //Act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero true
        }
    }
}