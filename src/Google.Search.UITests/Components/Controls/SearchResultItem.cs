using Atata;

namespace Google.Search.UITests
{
    [ControlDefinition("div", ContainingClass = "rc", ComponentTypeName = "search result item")]
    public class SearchResultItem<TOwner> : Control<TOwner>
        where TOwner : PageObject<TOwner>
    {
        public H3<TOwner> Title { get; private set; }

        [FindByXPath("cite")]
        public Text<TOwner> Url { get; private set; }

        [FindByClass("st")]
        public Text<TOwner> ShortText { get; private set; }
    }
}
