using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Avataweb.Tests
{
    [TestClass]
    public class AvataExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Valida a extensão AvatWeb")]

        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("edcastanha@gmail.com", true)] 
        
        //email de validação
                //A42B82740EEB7B5E565DA8B32DC333CD
        
        public void TestValidaGavatar(string email, bool status)
        {
            var resultado = "https://www.gravatar.com/avatar/A42B82740EEB7B5E565DA8B32DC333CD";
            Assert.AreEqual((email.ToAvata() == resultado), status);

        }
    }
}
