using NUnit.Framework;
using RallyTeam.UILocators;
using RallyTeam.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using System.Reflection;

namespace RallyTeam.TestScripts
{
    [TestFixture]
    [Category("Onboarding")]
    public class OnboardingTest : BaseTestWithoutLogin
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static ReadData readOnboarding = new ReadData("Onboarding");
        String workEmail;
        StringBuilder builder;

        //Signing up a new user
        public void SignUpNewUser()
        {
            commonPage.NavigateToExternalStorm(_externalStormURL);
            Thread.Sleep(2000);

            //Click SignUp link
            Thread.Sleep(2000);
            authenticationPage.ClickOnSignUpLink();
            log.Info("Click SignUp option given to the user.");
            Thread.Sleep(2000);

            builder = new StringBuilder();
            builder.Append(RandomString(6));

            //Enter First Name on the screen
            registrationPage.EnterFirstName(builder.ToString());
            log.Info("Enter First Name on the screen.");
            Thread.Sleep(2000);

            //Enter Last Name on the screen
            registrationPage.EnterLastName(builder.ToString());
            log.Info("Enter Last Name on the screen.");
            Thread.Sleep(2000);

            //Enter Work Email on the screen
            workEmail = builder + "@mailinator.com";
            registrationPage.EnterWorkEmail(workEmail);
            log.Info("Enter Work Email on the screen.");
            Thread.Sleep(4000);

            //Click SignUp button on the screen
            registrationPage.ClickSignUpBtn();
            log.Info("Click SignUp button on the screen.");
            Thread.Sleep(5000);

            //Enter Create a Password field on the screen
            registrationPage.EnterCreatePwdFields("Logica360");
            log.Info("Enter Create a Password field on the screen.");
            Thread.Sleep(2000);

            //Enter Confirm Password field on the screen
            registrationPage.EnterConfirmPwdFields("Logica360");
            log.Info("Enter Confirm Password field on the screen.");
            Thread.Sleep(2000);

            //Click Next Button on the screen
            registrationPage.ClickNextBtn();
            log.Info("Click Next button on the screen.");
            Thread.Sleep(10000);
        }

        public void MoveToWelcomePage()
        {
            //Navigate to the user inbox
            commonPage.NavigateToUrl("https://www.mailinator.com/");
            log.Info("Navigate to the mailinator site.");
            Thread.Sleep(5000);

            //Enter Mailinator Email address
            onboardingPage.EnterMailinatorEmail(workEmail);
            log.Info("Enter email address.");
            Thread.Sleep(2000);

            //Click on Go button
            onboardingPage.ClickGoBtn();
            log.Info("Click Go button.");
            Thread.Sleep(5000);

            //Click the Email Sender
            onboardingPage.ClickEmailSender();
            log.Info("Click the Email Sender.");
            Thread.Sleep(5000);

            //Switch to Iframe
            onboardingPage.SwitchIframe();
            Thread.Sleep(2000);

            //Get the Email Link and navigate
            String emailLink = onboardingPage.GetEmailLink();
            Console.WriteLine("EMAIL: " + emailLink);
            commonPage.NavigateToUrl(emailLink);
            log.Info("Navigate to the Email Link.");
            Thread.Sleep(5000);

            //Enter the registered Work Email
            Thread.Sleep(2000);
            authenticationPage.SetUserName(workEmail);
            log.Info("Enter registered work email.");
            Thread.Sleep(2000);

            //Enter valid password
            authenticationPage.SetPassword("Logica360");
            log.Info("Enter valid password.");
            Thread.Sleep(2000);

            //Click the Let's Go button            
            onboardingPage.ClickLetsGoBtn();
            log.Info("Click Let's Go button.");
            Thread.Sleep(7000);
        }

        [Test]
        public void Onboarding_001_SignUpNewProfile()
        {
            Global.MethodName = "Onboarding_001_SignUpNewProfile";
            SignUpNewUser();
            Thread.Sleep(2000);

            //Verify the We Just Sent You An Email message
            onboardingPage.VerifyWeJustSentYouAnEmailMsg();
            log.Info("Verify the We Just Sent You An Email message.");
            Thread.Sleep(1000);

            //Verify Resend Email button
            onboardingPage.VerifyResendEmailbtn();
            log.Info("Verify Resend Email button.");
            Thread.Sleep(2000);
        }

        [Test]
        public void Onboarding_002_VerifyEmailReceived()
        {
            Global.MethodName = "Onboarding_002_VerifyEmailReceived";
            SignUpNewUser();

            //Navigate to the user inbox
            commonPage.NavigateToUrl("https://www.mailinator.com/");
            log.Info("Navigate to the mailinator site.");
            Thread.Sleep(5000);

            //Enter Mailinator Email address
            onboardingPage.EnterMailinatorEmail(workEmail);
            log.Info("Enter email address.");
            Thread.Sleep(2000);

            //Click on Go button
            onboardingPage.ClickGoBtn();
            log.Info("Click Go button.");
            Thread.Sleep(5000);

            //Refresh page
            commonPage.RefreshPage();
            Thread.Sleep(3000);

            //Verify the Email Sender
            onboardingPage.VerifyEmailSender();
            log.Info("Verify the Email Sender.");
            Thread.Sleep(2000);

            //Verify the Email Subject
            onboardingPage.VerifyEmailSubject();
            log.Info("Verify the Email Subject.");
            Thread.Sleep(2000);

            //Click the Email Sender
            onboardingPage.ClickEmailSender();
            log.Info("Click the Email Sender.");
            Thread.Sleep(5000);

            //Switch to Iframe
            onboardingPage.SwitchIframe();
            Thread.Sleep(2000);

            //Verify the button Verify Your Email
            onboardingPage.VerifyYourEmailBtn();
            log.Info("Verify the button: Verify your Email.");
            Thread.Sleep(3000);

            //Get the Email Link and navigate
            String emailLink = onboardingPage.GetEmailLink();
            Console.WriteLine("EMAIL: " + emailLink);
            commonPage.NavigateToUrl(emailLink);
            log.Info("Navigate to the Email Link.");
            Thread.Sleep(5000);

            //Login page should be displayed
            authenticationPage.VerifyLoginPage();
            log.Info("Verify Login Url Page");            
        }

        [Test]
        public void Onboarding_003_LoginAndVerifyWelcomePage()
        {
            Global.MethodName = "Onboarding_003_LoginAndVerifyWelcomePage";
            SignUpNewUser();
            MoveToWelcomePage();

            //Verify the Welcome User Message
            onboardingPage.VerifyWelcomeUserMsg(builder.ToString());
            log.Info("Verify the Welcome User Message.");
            Thread.Sleep(1000);

            //Verify the Welcome RallyTeam Description message
            onboardingPage.VerifyWelcomeRallyTeamDescriptionMsg();
            log.Info("Verify the Welcome RallyTeam Description message.");
            Thread.Sleep(1000);

            //Verify the Get Started button
            onboardingPage.VerifyGetStartedBtn();
            log.Info("Verify Get Started button.");
        }

        [Test]
        public void Onboarding_004_VerifyLinkedInPage()
        {
            Global.MethodName = "Onboarding_004_VerifyLinkedInPage";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Verify the LinkeDin Confirmation message
            onboardingPage.VerifyLinkedInConfirmationMsg();
            log.Info("Verify the LinkeDin Confirmation message.");
            Thread.Sleep(1000);

            //Verify the Connect with LinkedIn button
            onboardingPage.VerifyConnectWithLinkedInbtn();
            log.Info("Verify the Connect with LinkedIn button.");
            Thread.Sleep(1000);

            //Verify the Skip LinkedIn Option
            onboardingPage.VerifySkipLinkedIn();
            log.Info("Verify Skip LinkedIn Option.");
        }

        [Test]
        public void Onboarding_005_VerifyUploadResumePage()
        {
            Global.MethodName = "Onboarding_005_VerifyUploadResumePage";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Verify the Upload Your Resume message
            onboardingPage.VerifyUploadResumeMsg();
            log.Info("Verify the Upload Your Resume message.");
            Thread.Sleep(1000);

            //Verify the Upload Your Resume button
            onboardingPage.VerifyUploadYourResumeBtn();
            log.Info("Verify the Upload Your Resume button.");
            Thread.Sleep(1000);

            //Verify the Skip Upload Resume Option
            onboardingPage.VerifySkipUploadResume();
            log.Info("Verify Skip Upload Resume Option.");
        }

        [Test]
        public void Onboarding_006_VerifyWorkPage()
        {
            Global.MethodName = "Onboarding_006_VerifyWorkPage";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Skip the Upload Resume Step
            onboardingPage.ClickSkipUploadResume();
            log.Info("Click Skip Upload Resume option.");
            Thread.Sleep(5000);

            //Verify the What Do You Work In message
            onboardingPage.VerifyWhatDoYouWorkInMsg();
            log.Info("Verify the What Do You Work In message.");
            Thread.Sleep(1000);

            //Verify the Work Drop-Down
            onboardingPage.VerifyWorkDropDown();
            log.Info("Verify the Work Drop-Down.");
            Thread.Sleep(1000);

            //Verify the Continue button
            onboardingPage.VerifyContinueBtn();
            log.Info("Verify Continue button.");
        }

        [Test]
        public void Onboarding_007_SelectWorkAndVerifySkillsPage()
        {
            Global.MethodName = "Onboarding_007_SelectWorkAndVerifySkillsPage";
            SignUpNewUser();
            MoveToWelcomePage();
            
            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Skip the Upload Resume Step
            onboardingPage.ClickSkipUploadResume();
            log.Info("Click Skip Upload Resume option.");
            Thread.Sleep(5000);

            //Select Work
            onboardingPage.SelectWorkDropDown("Information Technology");
            log.Info("Select Work drop-down option.");
            Thread.Sleep(2000);

            //Click Continue button
            onboardingPage.ClickContinueBtn();
            log.Info("Click Continue button.");
            Thread.Sleep(3000);

            //Verify the Are these your top three skills? message
            onboardingPage.VerifyAreTheseYourTopSkillsMsg();
            log.Info("Verify the Are these your top three skills? message.");
            Thread.Sleep(1000);

            //Verify the Skills Div
            onboardingPage.VerifySkillsDiv();
            log.Info("Verify the Skills Div.");
            Thread.Sleep(1000);

            //Count the Number of Skills and fail if more than 3
            onboardingPage.CountSkillsAndFailIfMoreThanThree();
            log.Info("Count the number of skills and fail if more than 3.");
            Thread.Sleep(1000);

            //Verify the Continue Skills button
            onboardingPage.VerifyContinueSkillsBtn();
            log.Info("Verify Continue Skills button.");
        }

        [Test]
        public void Onboarding_008_VerifyInterestsPage()
        {
            Global.MethodName = "Onboarding_008_VerifyInterestsPage";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Skip the Upload Resume Step
            onboardingPage.ClickSkipUploadResume();
            log.Info("Click Skip Upload Resume option.");
            Thread.Sleep(5000);

            //Click Continue button
            onboardingPage.ClickContinueBtn();
            log.Info("Click Continue button.");
            Thread.Sleep(3000);

            //Click Continue Skills button
            onboardingPage.ClickContinueSkillsBtn();
            log.Info("Click Continue Skills button.");
            Thread.Sleep(3000);

            //Verify the What are you interested in? message
            onboardingPage.VerifyWhatAreYouInterestedInMsg();
            log.Info("Verify the What are you interested in? message.");
            Thread.Sleep(1000);

            //Verify the Interests Div
            onboardingPage.VerifyInterestsDiv();
            log.Info("Verify the Interests Div.");
            Thread.Sleep(1000);

            //Verify the Lets Get You Matched button
            onboardingPage.VerifyLetsGetYouMatchedBtn();
            log.Info("Verify Lets Get You Matched button.");
        }

        [Test]
        public void Onboarding_009_ClickLetsGetMatchedAndVerify()
        {
            Global.MethodName = "Onboarding_009_ClickLetsGetMatchedAndVerify";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Skip the Upload Resume Step
            onboardingPage.ClickSkipUploadResume();
            log.Info("Click Skip Upload Resume option.");
            Thread.Sleep(5000);

            //Click Continue button
            onboardingPage.ClickContinueBtn();
            log.Info("Click Continue button.");
            Thread.Sleep(3000);

            //Click Continue Skills button
            onboardingPage.ClickContinueSkillsBtn();
            log.Info("Click Continue Skills button.");
            Thread.Sleep(3000);

            //Enter Interests Input
            onboardingPage.EnterInterests("ILikeIt");
            log.Info("Enter Interests Input");
            Thread.Sleep(2000);                    

            //Click Lets Get You Matched button
            onboardingPage.ClickLetsGetYouMatchedBtn();
            log.Info("Click Lets Get You Matched button.");
            Thread.Sleep(5000);

            //Verify the Marketplace tab
            onboardingPage.VerifyMarketplaceTab();
            log.Info("Verify Marketplace tab.");
        }

        [Test]
        public void Onboarding_010_UploadResumeAndVerifySkills()
        {
            Global.MethodName = "Onboarding_010_UploadResumeAndVerifySkills";
            SignUpNewUser();
            MoveToWelcomePage();

            //Click Get Started Button
            onboardingPage.ClickGetStartedBtn();
            log.Info("Click Get Started button.");
            Thread.Sleep(5000);

            //Skip the LinkedIn Step
            onboardingPage.ClickSkipLinkedIn();
            log.Info("Click Skip LinkedIn option.");
            Thread.Sleep(5000);

            //Click the Upload Your Resume button
            onboardingPage.ClickUploadYourResumeBtn();
            log.Info("Click the Upload Your Resume button.");
            Thread.Sleep(1000);
            String startupPath = System.IO.Directory.GetCurrentDirectory() + "\\TestData";
            startupPath = startupPath + "\\AuzebManzoor.pdf";
            Thread.Sleep(2000);
            SendKeys.SendWait(@startupPath);
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(5000);  
        }









    }
}
