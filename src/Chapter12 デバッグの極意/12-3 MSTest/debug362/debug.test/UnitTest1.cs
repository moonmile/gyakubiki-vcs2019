using System;
using debug362;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace debug.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ���l�̉��Z()
        {
            var t = new TargetClass();
            int ans = t.add(10, 20);
            Assert.AreEqual(30, ans);
        }
        [TestMethod]
        public void ������̌���()
        {
            var t = new TargetClass();
            string ans = t.add("�}�X�_", "�g���A�L");
            Assert.AreEqual("�}�X�_�g���A�L", ans);
        }
        [TestMethod]
        public void NULL�`�F�b�N()
        {
            var t = new TargetClass();
            var obj = t.CreatePointer(10, 20);
            Assert.IsNotNull(obj);
            Assert.AreEqual(10, obj.X);
            Assert.AreEqual(20, obj.Y);
        }
    }
}
