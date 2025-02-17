using HerfaTest_Batch_6.Data;
using HerfaTest_Batch_6.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject1.POM;

namespace HerfaTest_Batch_6.AssistantMethods
{
    public class Register_AssistantMethods
    {
        public static void FillRegisterForm(User user)
        {
            Register_POM register_POM = new Register_POM(ManageDriver.driver);
            register_POM.EnterFirstName(user.FirstName);
            register_POM.EnterLastName(user.LastName);
            register_POM.EnterEmail(user.Email);
            register_POM.EnterPhoneNumber(user.Phone);
            register_POM.EnterPassword(user.Password);
            register_POM.EnterConfirmationPassword(user.ConfirmPassword);
            register_POM.DateOfBirth(user.BirthDate);
            if (user.Gender == Gender.Male)
            {
                register_POM.MaleButton();
            }
            else if (user.Gender == Gender.Female)
            {
                register_POM.FemaleButton();

            }
            register_POM.ClickSubmitButton1();
        }
    }
}
