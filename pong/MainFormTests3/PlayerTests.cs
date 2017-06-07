using Microsoft.VisualStudio.TestTools.UnitTesting;
using MainForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm.Tests
{
    [TestClass()]
    public class PlayerTests
    {
        [TestMethod()]
        public void PlayerTestNotNull()
        {
            Player player = new Player("URI");
            Assert.IsNotNull(player);
        }

        [TestMethod()]
        public void PlayerTestIsNull()
        {
            Player player = null;
            Assert.IsNull(player);
        }

        [TestMethod()]
        [Timeout(TestTimeout.Infinite)]  // Milliseconds
        public void saveTestIsCreatedTrue()
        {
            // No pasa el test
            Player player = new Player("UNIX");
            bool actual = player.save();
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTestNotNull()
        {
            Player player = new Player("Franklin");
            Assert.IsTrue(player.ToString() != null);
            Console.WriteLine(player.ToString());
        }

        [TestMethod()]
        public void ToStringTestIsNull()
        {
            Player player = new Player();
            Assert.IsNull(player.ToString());
        }
    }
}