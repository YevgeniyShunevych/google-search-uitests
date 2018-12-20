using Atata;
using OpenQA.Selenium;

namespace Google.Search.UITests
{
    using _ = HomePage;

    public class HomePage : Page<_>
    {
        [FindFirst]
        public TextInput<_> Query { get; private set; }

        public SearchResultsPage Search(string query)
        {
            Query.Set(query);
            Press(Keys.Enter);

            return Go.To<SearchResultsPage>();
        }
    }
}
