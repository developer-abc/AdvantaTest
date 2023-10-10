namespace ds.test.impl.tests
{
    public class PluginTests
    {
        public PluginTests()
        {
            
        }

        [Fact]
        public void LibraryHasOnlyTwoPublicMembers()
        {
            var assembly = typeof(ds.test.impl.Plugins).Assembly;
            var publicTypes = assembly.GetTypes().Where(t => t.IsPublic);
            Assert.Equal(2, publicTypes.Count());
            // public class Plugins
            Assert.Contains(publicTypes, t => t.IsClass);
            // public interface IPlugin
            Assert.Contains(publicTypes, t => t.IsInterface);
        }

        [Fact]
        public void Addition_AddsTwoNumbers_ReturnsTheirSum()
        {
            var result = Plugins.GetPlugin("Addition Plugin").Run(2,3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Multiplication_MultipliesTwoNumbers_ReturnsTheirProduct()
        {
            var result = Plugins.GetPlugin("Multiplication Plugin").Run(2, 3);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Subtraction_SubtractsSecondNumberFromFirst_ReturnsDifference()
        {
            var result = Plugins.GetPlugin("Subtraction Plugin").Run(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Division_DividesFirstNumberBySecond_ReturnsQuotient()
        {
            var result = Plugins.GetPlugin("Division Plugin").Run(6, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Division_DividesByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Plugins.GetPlugin("Division Plugin").Run(6, 0));
        }

        [Fact]
        public void Modulus_CalculatesModulus_ReturnsRemainder()
        {
            var result = Plugins.GetPlugin("Modulus Plugin").Run(10, 3);
            Assert.Equal(1, result);
        }

        [Fact]
        public void Modulus_DividesByZero_ThrowsDivideByZeroException()
        {
            Assert.Throws<DivideByZeroException>(() => Plugins.GetPlugin("Modulus Plugin").Run(10, 0));
        }

        [Fact]
        public void Power_CalculatesPower_ReturnsResult()
        {
            var result = Plugins.GetPlugin("Power Plugin").Run(2, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void SquareRoot_CalculatesSquareRoot_ReturnsResult()
        {
            var result = Plugins.GetPlugin("Square Root Plugin").Run(9, 0);
            Assert.Equal(3, result);
        }

        [Fact]
        public void SquareRoot_NegativeNumber_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Plugins.GetPlugin("Square Root Plugin").Run(-1, 0));
        }
    }

}