
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static IWebDriver driver = new ChromeDriver();
    static IWebElement userName;
    static IWebElement passWord;
    static IWebElement submitBtn;
    static IWebElement successAlert;

    static void Main()
    {

        //This is a great mock testing site the-internet.herokuapp.com
        driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

         userName = driver.FindElement(By.CssSelector("input[name=username]"));
        passWord = driver.FindElement(By.Id("password"));
        submitBtn = driver.FindElement(By.CssSelector("button[type=submit]"));

        userName.SendKeys("tomsmith");
        passWord.SendKeys("SuperSecretPassword!");
        submitBtn.Click();

        successAlert = driver.FindElement(By.Id("flash"));

        Console.WriteLine(successAlert.Text);


        if (successAlert.Text.Contains("You logged into a secure area!"))
        {
            Console.WriteLine("Logged in Successfully!");
        }
        else
        {
            Console.WriteLine("Did not login");
        }






/*


        if (element.Displayed)
        {
            System.Console.WriteLine("found element");
        }
        else
        {
            System.Console.WriteLine("did not find element");
        }*/

        //driver.Quit();

    }
}

