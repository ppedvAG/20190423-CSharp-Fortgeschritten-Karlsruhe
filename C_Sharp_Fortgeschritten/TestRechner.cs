using C_Sharp_Fortgeschritten.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Fortgeschritten
{
    [TestClass]
    public class TestRechner
    {
        [TestMethod]
        public void TestParser()
        {
            var parser = new ParserV2();
            var result = parser.Parse("5+3");

            Assert.AreEqual(5, result.op1);
            Assert.AreEqual("+", result.method);
            Assert.AreEqual(3, result.op2);
        }
        [TestMethod]
        public void TestParserErweitert()
        {
            var parser = new ParserV2();
            var result = parser.Parse(" fs5f fsdf + hrfhh&3 $§%§%$§");

            Assert.AreEqual(5, result.op1);
            Assert.AreEqual("+", result.method);
            Assert.AreEqual(3, result.op2);
        }

        [TestMethod]
        public void TestParserErweitertMinus()
        {
            var parser = new ParserV2();
            var result = parser.Parse(" fs5f fsdf - hrfhh&3 $§%§%$§");

            Assert.AreEqual(5, result.op1);
            Assert.AreEqual("-", result.method);
            Assert.AreEqual(3, result.op2);
        }
    }
}
