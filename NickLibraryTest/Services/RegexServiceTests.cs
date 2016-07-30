using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NickLibrary.Services.Tests
{
    [TestClass()]
    public class RegexServiceTests
    {
        [TestMethod()]
        public void IsChinese_EnglishValue_False()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = false;
            //Acaual
            bool actual = regexService.IsChinese("English");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsChinese_ChineseValue_Ture()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = true;
            //Acaual
            bool actual = regexService.IsChinese("林菘彬");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsChinese_MixValue_Ture()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = false;
            //Acaual
            bool actual = regexService.IsChinese("L林fd菘1彬");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsChinese_MixEnglishIBeforeChinese_Ture()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = false;
            //Acaual
            bool actual = regexService.IsChinese("Lin林菘彬");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsChinese_MixEnglishIAfterChinese_Ture()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = false;
            //Acaual
            bool actual = regexService.IsChinese("林菘彬Lin");
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void IsChinese_NumberValue_Ture()
        {
            //Arrange
            RegexService regexService = new RegexService();
            bool expected = false;
            //Acaual
            bool actual = regexService.IsChinese("1234");
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}