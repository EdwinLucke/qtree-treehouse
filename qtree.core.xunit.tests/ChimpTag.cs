using qtree.standard.lib;
using qtree.standard.lib.v01;
using System;
using Xunit;

namespace qtree.core.xunit.tests
{
    public class ChimpTagTest
    {
        [Fact]
        public void TechnologyTypes_Check()
        {
            var types = TechnologyTypes.Core | TechnologyTypes.Net | TechnologyTypes.Other | TechnologyTypes.Standard;
            var values = Enum.GetValues(typeof(TechnologyTypes));

            //Assert.Is
            Assert.True(values.Length == 4);
            Assert.IsType(typeof(TechnologyTypes), types);
        }
        [Fact]
        public void ChimpTag_Molly_Tag_Charlie()
        {
            //Arrange
            var ChimpCharlie = new Chimp(4) { Name = "Charlie Xu" };
            var ChimpMolly = new Chimp(5) { Name = "Xu. Molly" };
            //Act
            ChimpMolly.PlayWith(ChimpCharlie);
            //Assert
            Assert.False(ChimpCharlie.HasEnergy());
            Assert.True(ChimpMolly.HasEnergy());
            Assert.True(ChimpCharlie.IsTagged());
        }
    }
}
