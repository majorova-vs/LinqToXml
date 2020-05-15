using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cars;


namespace TestingCars
{
    [TestClass]
    public class TestingCarsData
    {
        CheckForRightData t = new CheckForRightData();
        [TestMethod]
        public void TestForEmptyStrings()
        {
            
            string v1 = "";
            string v2 = "";
            string v3="";
            string v4 ="";
            string v5 = "";
            bool expectedValue = false;
            bool actualValue = t.CheckInputValues(v1, v2, v3, v4, v5);
  
            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на пустые строки не пройдена");
        }
        [TestMethod]
        public void TestForHalfEmptyStrings()
        {

            string v1 = "12";
            string v2 = "90";
            string v3 = "123";
            string v4 = "";
            string v5 = "";
            bool expectedValue = false;
            bool actualValue = t.CheckInputValues(v1, v2, v3, v4, v5);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на пустые строки не пройдена");
        }
        [TestMethod]
        public void TestForRightType()
        {

            string v1 = "123";
            string v2 = "58";
            string v3 = "123";
            string v4 = "6000";
            string v5 = "90";
            bool expectedValue = true;
            bool actualValue = t.CheckInputValues(v1, v2, v3, v4, v5);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }
        [TestMethod]
        public void TestForWrongType()
        {
           
            string v1 = "ASD";
            string v2 = "erdfg";
            string v3 = "123";
            string v4 = "000";
            string v5 = "ASFnb";
            bool expectedValue = false;
            bool actualValue = t.CheckInputValues(v1, v2, v3, v4, v5);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }
        [TestMethod]
        public void TestForWrongType2()
        {
            string v1 = "1-32=4";
            string v2 = "erdfg";
            string v3 = "123";
          
            bool expectedValue = false;
            bool actualValue = t.CheckInputValues2(v1, v2, v3);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }
        [TestMethod]
        public void TestForEmptyStrings2()
        {
            string v1 = "";
            string v2 = "";
            string v3 = "";

            bool expectedValue = false;
            bool actualValue = t.CheckInputValues2(v1, v2, v3);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }
        [TestMethod]
        public void TestForRightType2()
        {
            string v1 = "Afgh";
            string v2 = "123";
            string v3 = "123";

            bool expectedValue = true;
            bool actualValue = t.CheckInputValues2(v1, v2, v3);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }

        [TestMethod]
        public void TestForRightResult()
        {
            string v1 = "340";
            string v2 = "123";
            

            bool expectedValue = true;
            bool actualValue = t.CheckInputValues3(v1, v2);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }

        [TestMethod]
        public void TestForWrongResult()
        {
            string v1 = "34";
            string v2 = "123";


            bool expectedValue = false;
            bool actualValue = t.CheckInputValues3(v1, v2);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }

        [TestMethod]
        public void TestForRightResult2()
        {
            string v1 = "123";
            string v2 = "123";


            bool expectedValue = true;
            bool actualValue = t.CheckInputValues3(v1, v2);

            Assert.AreEqual(expectedValue, actualValue, "ѕроверка на неверные типы не пройдена");
        }
    }
}
