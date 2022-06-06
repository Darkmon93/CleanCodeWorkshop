using CleanCodeWorkshop.Task_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskVerify
{
    [TestClass]
    public class Task2
    {
        private SanitizeTitleDirty DirtySanitizer = new SanitizeTitleDirty();
        private SanitizeTitleClean CleanSanitizer = new SanitizeTitleClean();
        
        [TestMethod]
        public void SanitizeTitle()
        {
            var title = "[Title123.]";
            Assert.AreEqual(DirtySanitizer.Sanitize(title), CleanSanitizer.Sanitize(title));
        }

        [TestMethod]
        public void Sanitize_RemoveBrackets()
        {
            var title = "[Title123]";
            Assert.AreEqual("Title123", CleanSanitizer.Sanitize(title));
        }

        [TestMethod]
        public void Sanitize_RemoveEndDot()
        {
            var title = "T.i.t.l.e.1.2.3.";
            Assert.AreEqual("T.i.t.l.e.1.2.3", CleanSanitizer.Sanitize(title));
        }

        [TestMethod]
        public void Sanitize_TrimSpaces()
        {
            var title = " T i t l e 1 2 3 ";
            Assert.AreEqual("T i t l e 1 2 3", CleanSanitizer.Sanitize(title));
        }
    }
}
