using Atata;

namespace Google.Search.UITests
{
    using _ = SearchResultsPage;

    public class SearchResultsPage : Page<_>
    {
        public ControlList<SearchResultItem<_>, _> Results { get; private set; }
    }
}
