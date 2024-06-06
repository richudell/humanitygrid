using System.Numerics;
using Xunit;

namespace HumanityGrid.ECPP.Tests
{
    public class EcppAlgorithmTests
    {
        private readonly EcppAlgorithm _ecpp;

        public EcppAlgorithmTests()
        {
            _ecpp = new EcppAlgorithm();
        }

        [Fact]
        public void IsPrime_ReturnsTrue_ForPrimeNumbers()
        {
            Assert.True(_ecpp.IsPrime(2));
            Assert.True(_ecpp.IsPrime(3));
            Assert.True(_ecpp.IsPrime(5));
            Assert.True(_ecpp.IsPrime(7));
            Assert.True(_ecpp.IsPrime(11));
            Assert.True(_ecpp.IsPrime(13));
        }

        [Fact]
        public void IsPrime_ReturnsFalse_ForNonPrimeNumbers()
        {
            Assert.False(_ecpp.IsPrime(1));
            Assert.False(_ecpp.IsPrime(4));
            Assert.False(_ecpp.IsPrime(6));
            Assert.False(_ecpp.IsPrime(8));
            Assert.False(_ecpp.IsPrime(9));
            Assert.False(_ecpp.IsPrime(10));
        }
    }
}
