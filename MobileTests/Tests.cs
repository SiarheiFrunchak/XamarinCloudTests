using NUnit.Framework;
using Xamarin.UITest;

namespace MobTest
{
    [TestFixture]
	public class Tests
	{
        MobTestHelpercs appHelper = new MobTestHelpercs();

        [SetUp]
        public void OnceSetUp()
        {
           MobTestHelpercs.app = AppInstaler.StartApp(Platform.Android, "D:/SeleniumTests/App Data/test.apk");
        }

        [Test]
        public void CatalogTest()
        {
            appHelper.GoToNavigationPage();
            appHelper.SumsungSearch();

            Assert.AreEqual(true, appHelper.SearchResultCheck());
        }

        [Test]
        public void NewComersPageTest()
        {
            Assert.AreEqual(true, appHelper.NewComersPageCheck());
        }
    }
}
