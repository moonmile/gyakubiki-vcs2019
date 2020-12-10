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
                // 例外を発生させる
                t.FireException();
            }
            catch ( Exception ex )
            {
                // 例外が発生したためテストは成功
                Assert.AreEqual("例外発生", ex.Message);
                return;
            }
            // 例外が発生しない場合はテストは失敗
            Assert.Fail();
        }
    }
}
