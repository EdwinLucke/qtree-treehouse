using Microsoft.VisualStudio.TestTools.UnitTesting;
using qtree.standard.lib;

/// <summary>
/// Unittesting of a simple ChimpTag game.
/// </summary>
namespace qtree.core.mstest.tests
{
    [TestClass]
    public class ChimpTagTest
    {
        [TestMethod]
        public void ChimpTag_Molly_Tag_Charlie()
        {
            //Arrange
            var ChimpCharlie = new Chimp(4) {Name = "Charlie" };
            var ChimpMolly = new Chimp(5) { Name = "Molly" };
            //Act
            ChimpMolly.PlayWith(ChimpCharlie);
            //Assert
            Assert.IsFalse(ChimpCharlie.HasEnergy());
            Assert.IsTrue(ChimpMolly.HasEnergy());
            Assert.IsTrue(ChimpCharlie.IsTagged());
        }
    }
}
