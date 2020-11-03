using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MDG.Core;
using System.Collections.Generic;

namespace Plugin_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<string> points = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            AcC3D_Plug.Computations.BeautifyPointList(points);
            points = new List<string> { "20", "21",  "22", "23", "24", "26", "27", "28", "29", "30"};
            AcC3D_Plug.Computations.BeautifyPointList(points);
            points = new List<string> { "1", "2", "3", "5", "6", "7", "9", "10" };
            AcC3D_Plug.Computations.BeautifyPointList(points);
            points = new List<string> { "1", "2", "3", "5", "6", "7", "9", "10", "20", "30" };
            AcC3D_Plug.Computations.BeautifyPointList(points);
            points = new List<string> { "1" , "2" };
            AcC3D_Plug.Computations.BeautifyPointList(points);
        }
    }
}
