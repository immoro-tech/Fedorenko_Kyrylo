namespace OrangeHRMTests
{
    [Binding]
    public sealed class ScenarioTest
    {
        private const string WebsiteUrl = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";
        private IWebDriver _driver;

        [SetUp]
        public void Setup()
        {
            _driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(WebsiteUrl);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void AuthorizationTest()
        {
            var logPage = new SignInPage(_driver);
            var result = logPage.LoginAsAdmin(new UserList("Admin", "admin123"))
                .GoToAdminPanel()
                .GoToAddScenario()
                .CreateNewJob(new JobInfo("Odis  Adalwin", "Stepan Bandera", "@vumaL28", "@vumaL28"));
            Assert.False(result);
        }

        [OneTimeTearDown]
        public void CloseDriver()
        {
            _driver.Close();
        }
    }
}

