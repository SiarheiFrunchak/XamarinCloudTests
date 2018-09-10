using Xamarin.UITest;

namespace MobTest
{
    class MobTestHelpercs
    {
        public static IApp app;

        private static string nextViewBtn = "nextView";
        private static string searchField = "menu_search";
        public static string searchValue = "Samsung Galaxy A6+ (2018) 3GB/32GB (синий)";

        public void GoToNavigationPage()
        {
            for (int i = 0; i < 5; i++)
            {
                app.WaitForElement(c => c.Id("nextView"));
                app.Tap(c => c.Id(nextViewBtn));
                if (i == 5)
                    break;
            }
        }

        public void SumsungSearch()
        {
            app.Tap(c => c.Id(searchField));
            app.EnterText(c => c.Id(searchField), searchValue);
        }

        public bool SearchResultCheck()
        {
            app.WaitForElement(c => c.Id("text_name"));
            string searchResult = app.Query(c => c.Id("text_name"))[0].Text.ToString();

            return true ? (searchValue == searchResult) : false;
        }

        public bool NewComersPageCheck()
        {
            string actualResult = app.Query(c => c.Id("text_title"))[0].Text.ToString();
            string expectedResult = "Добро пожаловать!";

            return true ? (expectedResult == actualResult) : false;
        }
    }
}
