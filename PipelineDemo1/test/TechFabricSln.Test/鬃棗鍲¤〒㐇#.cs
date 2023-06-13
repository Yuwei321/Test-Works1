using NUnit.Framework;
namespace TechFabricSln.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Category("UnitTest")]
        public void 测试方法啊阿鼾齄丂丄狚狛狜狝﨨()
        {
            Assert.Pass();
        }

        [Test]
        [Category("UnitTest")]
        public void 测试方法癌蔼矮艾碍爱隘鼾D2丠両狛丣囆囇囈囉()
        {
            var bought = new Bought();

            var result = bought.IsBoughtBy(new User { customer = true });

            Assert.IsTrue(result);
        }
        [Test]
        [Category("UnitTest")]
        public void 测试方法舰剑饯渐溅涧建僵齄D2囌囍囎囏囐囓囑囒D3珸珹䲟珺珻珼珽現()
        {
            Assert.Pass();
        }

    }
}