using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagrama.Tests
{
    [TestClass()]
    public class GeradorAnagramasTests
    {
        [TestMethod()]
        public void GerarAnagramaTest()
        {
            var anagrama = new GeradorAnagramas(LeitorDicionario.LerDicionario());
            var listaPalavras = anagrama.GerarAnagramas("dog");
            Assert.IsTrue(listaPalavras.Contains("GOD"));
            Assert.IsTrue(listaPalavras.Count == 2);
        }

        [TestMethod()]
        public void GerarAnagramaTempoTest()
        {
            var anagrama = new GeradorAnagramas(LeitorDicionario.LerDicionario());
            var listaPalavras = anagrama.GerarAnagramas("ABDOMINAL");
            Assert.IsTrue(listaPalavras.Count == 1);
        }
    }
}