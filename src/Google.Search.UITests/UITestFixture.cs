using Atata;
using NUnit.Framework;

namespace Google.Search.UITests
{
    [TestFixture]
    public class UITestFixture
    {
        [SetUp]
        public void SetUp()
        {
            // Find information about AtataContext set-up on https://atata-framework.github.io/getting-started/#set-up.
            AtataContext.Configure().
                UseChrome().
                    WithArguments("start-maximized", "disable-infobars").
                UseBaseUrl("https://www.google.com").
                UseCulture("en-us").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                    WithMinLevel(LogLevel.Info).
                AddNLogLogging().
                    WithMinLevel(LogLevel.Trace).
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                AddScreenshotFileSaving().
                Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
