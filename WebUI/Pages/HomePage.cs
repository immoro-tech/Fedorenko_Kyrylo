namespace WebUI.Pages;

internal class HomePage : MainPage
{
    private static readonly By AdminLinkLocator = 
        By.XPath("//*[@id=\"app\"]/div[1]/div[1]/aside/nav/div[2]/ul/li[1]/a");
    
    private static readonly By AddMenuLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div[2]/div[1]/button");
    
    public HomePage(IWebDriver driver) : base(driver)
    {
        return;
    }

    public HomePage GoToAdminPanel()
    {
        Driver.FindElement(AdminLinkLocator).Click();
        return this;
    }

    private HomePage ClickOnAddMenu()
    {
        Driver.FindElement(AddMenuLocator).Click();
        return this;
    }

    public UserManagementPage GoToAddScenario()
    {
        
        ClickOnAddMenu();
        return new UserManagementPage(Driver);
    }
}