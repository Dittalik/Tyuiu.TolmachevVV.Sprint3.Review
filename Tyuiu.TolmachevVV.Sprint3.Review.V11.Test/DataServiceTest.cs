using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TolmachevVV.Sprint3.Review.V11.Lib;

namespace Tyuiu.TolmachevVV.Sprint3.Review.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Check()
        {
            DataService service1 = new DataService();
            double[] check = new double[5 - (-5) + 1];
            check[0] = 20.36;
            check[1] = 15.42;
            check[2] = 10.99;
            check[3] = 7.43;
            check[4] = 4.33;
            check[5] = 1;
            check[6] = 0;
            check[7] = -8.87;
            check[8] = -13.03;
            check[9] = -16.53;
            check[10] = -19.60;
            CollectionAssert.AreEqual(check, service1.GetMassFunction(-5, 5));
        }
    }
}
