using HerfaTest_Batch_6.Data;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.POM;
using HerfaTest_Batch_6.Helpers;
using OpenQA.Selenium.DevTools.V130.Browser;
using HerfaTest_Batch_6.AssistantMethods;

namespace HerfaTest_Batch_6.TestMethods
{
    [TestClass]
    public class Register_TestMethods
    {

        [TestMethod]
        public void TestRegister_validData()
        {
            ManageDriver.MaximizeDriver();
            CommonMethods.NavigateToURL(GlobalConstant.registerLink);
            Thread.Sleep(7000);
            User user = new User("Bayan", "Mohammad", "Bayan@gmail.com", "123", "123", "0783545455", "01-01-1999", Gender.Female);
            Register_AssistantMethods.FillRegisterForm(user);


            string expectedURL = GlobalConstant.loginLink;
            string actualURL = ManageDriver.driver.Url;

            Assert.AreEqual(actualURL, expectedURL);
            Console.WriteLine("Test Case completed Successfully");
        }

        [TestMethod]
        public void TestRegister_ConfirmationPassword()
        {
            ManageDriver.MaximizeDriver();
            CommonMethods.NavigateToURL(GlobalConstant.registerLink);
            Thread.Sleep(7000);
            User user = new User("Bayan", "Mohammad", "Bayan@gmail.com", "123", "1234", "0783545455", "01-01-1999", Gender.Female);
            Register_AssistantMethods.FillRegisterForm(user);

            string expectedText = "bad";
            string actualText = ManageDriver.driver.FindElement(By.XPath("//div/span[@id='confirmMessage']")).Text;
            
            Assert.AreEqual(expectedText, actualText);
            Console.WriteLine("Test Case Completed Successfully");
        }

        [TestMethod]
        public void TestRegister_InvalidPhoneNumber()
        {
            ManageDriver.MaximizeDriver();
            CommonMethods.NavigateToURL(GlobalConstant.registerLink);
            Thread.Sleep(7000);

            User user = new User("Bayan", "Mohammad", "Bayan@gmail.com", "123", "123", "0785", "01-01-1999", Gender.Female);
            Register_AssistantMethods.FillRegisterForm(user);

            string expectedText = "The PhoneNumber entered is incorrect.";
            ManageDriver.driver.FindElement(By.XPath("//div/button[@aria-label='Close']")).Click();
            string actualText = ManageDriver.driver.FindElement(By.XPath("//div/span[.='The PhoneNumber entered is incorrect.']")).Text;
      Assert.AreEqual(expectedText, actualText);
            Console.WriteLine("The Test Case has been completed successfully");

        }


     
}
}
