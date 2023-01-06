using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V106.Runtime;

namespace WebUI.Pages;

internal class UserManagementPage : MainPage
{
   
    
    private static readonly By EmployeeNameLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div/input");

    private static readonly By EmployeeNameSelectLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[2]/div/div[2]/div/div[2]/div/span");

    private static readonly By UsernameLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[4]/div/div[2]/input");

    private static readonly By PasswordLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[1]/div/div[2]/input");
    
    private static readonly By ConfirmPasswordLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[2]/div/div[2]/div/div[2]/input");
    
    private static readonly By UserRoleLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div");

    private static readonly By SelectUserRoleLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[1]/div/div[2]/div/div[2]/div[3]/span");

    private static readonly By StatusLocator =
        By.XPath("//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div/div[2]/i");

    private static readonly By SelectStatusLocator =
        By.XPath($"//*[@id=\"app\"]/div[1]/div[2]/div[2]/div/div/form/div[1]/div/div[3]/div/div[2]/div/div[2]/div[2]/span");

    private static readonly By SaveButtonLocator =
        By.XPath("//button[@type='submit']");

    private static readonly By ButtonDeleteLocator =
        By.CssSelector(".oxd-table-card:nth-child(4) .oxd-icon-button:nth-child(1) > .oxd-icon");

    private static readonly By AssertButtonDeleteLocator =
        By.XPath("//button[contains(.,' Yes, Delete')]");

    
    public UserManagementPage(IWebDriver driver) : base(driver)
    {
        return;
    }

    

    private UserManagementPage EntryUserRole()
    {
        Driver.FindElement(UserRoleLocator).Click();
        Driver.FindElement(SelectUserRoleLocator).Click();
        return this;
    }

    private UserManagementPage SelectStatus()
    {
        Driver.FindElement(StatusLocator).Click();
        Driver.FindElement(SelectStatusLocator).Click();
        return this;
    }

    private UserManagementPage InputInfo(JobInfo info)
    {
        
        Driver.FindElement(UsernameLocator).SendKeys(info.Username);
        Driver.FindElement(EmployeeNameLocator).SendKeys(info.EmployeeName);
        Driver.FindElement(EmployeeNameSelectLocator).Click();
        Driver.FindElement(PasswordLocator).SendKeys(info.Password);
        Driver.FindElement(ConfirmPasswordLocator).SendKeys(info.PasswordConfirm);
        
        return this;
    }

    private UserManagementPage ClickOnSaveButton()
    {

        Driver.FindElement(SaveButtonLocator).Click();
        return this;
    }


    private UserManagementPage DeleteJob()
    {
        WebDriverWait waitToLoad = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
        waitToLoad.Until(d => ButtonDeleteLocator);

        Driver.FindElement(ButtonDeleteLocator).Click();
        Driver.FindElement(AssertButtonDeleteLocator).Click();
        return this;
    }

    public bool CreateNewJob(JobInfo info)
    {
       
        EntryUserRole();
        SelectStatus();
        InputInfo(info);
        ClickOnSaveButton();
        DeleteJob();

        return false;


    }
}