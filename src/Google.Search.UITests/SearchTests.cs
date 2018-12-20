using Atata;
using NUnit.Framework;

namespace Google.Search.UITests
{
    public class SearchTests : UITestFixture
    {
        [Test]
        public void Search()
        {
            Go.To<HomePage>().
                Search("atata framework").
                    Report.Screenshot("Check Results").
                    Results[x => x.Url == "https://github.com/atata-framework"].Should.BeVisible().
                    Results[x => x.Url == "https://github.com/atata-framework"].ShortText.Should.ContainAll("test", "automation", "framework");
        }
    }
}
