using System;
using debug359;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace debug.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new TargetClass();
            string ans = t.add("�}�X�_", "�g���A�L");
            Assert.AreEqual("�}�X�_�g���A�L", ans);
        }
    }
}
