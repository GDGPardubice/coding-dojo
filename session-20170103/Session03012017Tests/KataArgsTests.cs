using Microsoft.VisualStudio.TestTools.UnitTesting;
using Session03012017;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session03012017.Tests
{
    [TestClass()]
    public class KataArgsTests
    {
        [TestMethod()]
        public void emptyArgsHasZeroSetFlags()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string>());
            Assert.AreEqual(0, kataArgs.Size);
        }

        [TestMethod()]
        public void oneArgSetsOneFlag()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string>{ "-l" });
            Assert.AreEqual(1, kataArgs.Size);
        }

        [TestMethod()]
        public void oneArgFlagWithStringValueHasSizeOne()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-l", "a" });
            Assert.AreEqual(1, kataArgs.Size);
        }
        [TestMethod()]
        public void twoArgFlagWithStringValueHasSizeTwo()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-l", "a","-p", "8080" });
            Assert.AreEqual(2, kataArgs.Size);
        }

        [TestMethod()]
        public void oneFlagWithoutValueAndOneFlagWithValueHasSizeTwo()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-l","-p", "8080" });
            Assert.AreEqual(2, kataArgs.Size);
        }

        [TestMethod()]
        public void portFlagHasCorrectValue()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-p", "8080" });
            Assert.AreEqual("8080", kataArgs.GetFlagValue("p"));
        }

        [TestMethod()]
        public void secondPortFlagHasCorrectValue()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-l", "-p", "8080" });
            Assert.AreEqual("8080", kataArgs.GetFlagValue("p"));
        }

        [TestMethod()]
        public void nonSetFlagReturnsNull()
        {
            var kataArgs = new KataArgs();
            kataArgs.ParseArgs(new List<string> { "-p", "8080" });
            Assert.AreEqual(null, kataArgs.GetFlagValue("l"));
        }

        [TestMethod()]
        public void noArgumentsParsedWithEmptySchema()
        {
            var kataArgs = new KataArgs();
            var schema = new Dictionary<string, string>();
            kataArgs.ParseArgs(new List<string> { "-l" }, schema);
            Assert.AreEqual(null, kataArgs.GetFlagValue("l"));
        }
    }
}