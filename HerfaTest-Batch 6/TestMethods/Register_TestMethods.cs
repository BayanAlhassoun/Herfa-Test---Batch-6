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
            Register_POM register_POM = new Register_POM(ManageDriver.driver);
            register_POM.EnterFirstName("Batool");
            register_POM.EnterLastName("Barakat");
            register_POM.EnterEmail("Batool94@gmail.com");
            register_POM.EnterPhoneNumber("0784553253");
            register_POM.EnterPassword("123456");
            register_POM.EnterConfirmationPassword("1234546");
            register_POM.DateOfBirth("02-02-1999");
            register_POM.FemaleButton();
            register_POM.ClickSubmitButton1();

            string expectedURL = GlobalConstant.loginLink;
            string actualURL = ManageDriver.driver.Url;

            Assert.AreEqual(actualURL, expectedURL);
            Console.WriteLine("Test Case completed Successfully");
        }
    
}
}
