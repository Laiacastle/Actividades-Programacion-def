
using System;
using ExerciciUtils;
namespace AcForTest
{

    public class AcForTest
    {
        [TestMethod]
        
        public static void TestArr6Nums{
            //Arrange
            int[] nums = new int[] {1, 4, 3, 2, 6, 4};
            int[] listaCorrecta = new int[] {1, 2, 3, 4, 4, 6};
            //Act
            int[] result = Utils.OrderDescArr(nums);
            //Assert
            Assert.areEqual(listaCorrecta, result);
        }
        
        [TestMethod]
        
        public static void TestArr2Nums{
            //Arange
            int nums[] = new int[] {1,10};
            int[] listaCorrecta = new int[] {10, 1};
            //Act
            int[] result = Utils.OrderDescArr(nums);
            //Assert
            Assert.areEqual(listaCorrecta, result);
        }
    }
}
