using activitiesUtils;
namespace EightTest
{
    [TestClass]
    public class EighteenTest
    {
        [TestMethod]
        public void Interval0()
        {
            //Arrange
            int num = 0;
            //act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero True
        }
        [TestMethod]
        public void Interval119()
        {
            //Arrange
            int num = 119;
            //act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero True
        }
        [TestMethod]
        public void Interval121()
        {
            //Arrange
            int num = 121;
            //act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(result); //Espero False
        }
        [TestMethod]
        public void IntervalNegatiu()
        {
            //Arrange
            int num = -1;
            //act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsFalse(result); //Espero False
        }
        [TestMethod]
        public void Interval1()
        {
            //Arrange
            int num = 1;
            //act
            bool result = Utils.IsValidAge(num);
            //Assert
            Assert.IsTrue(result); //Espero True
        }
    }
}