using System;
using debug361;
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
            try
            {
                // ��O�𔭐�������
                t.FireException();
            }
            catch ( Exception ex )
            {
                // ��O�������������߃e�X�g�͐���
                Assert.AreEqual("��O����", ex.Message);
                return;
            }
            // ��O���������Ȃ��ꍇ�̓e�X�g�͎��s
            Assert.Fail();
        }
    }
}
