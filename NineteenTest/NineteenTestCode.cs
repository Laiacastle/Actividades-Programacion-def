using activitiesUtils;
namespace NineteenTest
{
    [TestClass]
    public class NineteenTestCode
    {
        [TestMethod]
        public void DiscountAge11()
        {
            //Arrange
            int num = 11;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 50); //Espero 50%
        }
        [TestMethod]
        public void DiscountAge0()
        {
            //Arrange
            int num = 0;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 50); //Espero 50%
        }
        [TestMethod]
        public void DiscountAge14()
        {
            //Arrange
            int num = 14;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 25); //Espero 25%
        }
        [TestMethod]
        public void DiscountAge17()
        {
            //Arrange
            int num = 17;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 25); //Espero 25%
        }
        [TestMethod]
        public void DiscountAge19()
        {
            //Arrange
            int num = 19;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 0); //Espero 0%
        }
        [TestMethod]
        public void DiscountAge63()
        {
            //Arrange
            int num = 63;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 0); //Espero 0%
        }
        [TestMethod]
        public void DiscountAge66()
        {
            //Arrange
            int num = 66;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 30); //Espero 30%
        }
        [TestMethod]
        public void DiscountAge9999()
        {
            //Arrange
            int num = 9999;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 30); //Espero 30%
        }
        [TestMethod]
        public void DiscountNegative77()
        {
            //Arrange
            int num = -77;
            //Act
            int result = Utils.AppliedDiscount(num);
            //Assert
            Assert.AreEqual(result, 30); //Espero error
        }


    }
}