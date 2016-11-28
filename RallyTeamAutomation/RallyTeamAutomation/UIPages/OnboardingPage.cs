using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using RallyTeam.UILocators;
using RallyTeam.Util;
using System.Threading;
using RallyTeam.UILocators;

namespace RallyTeam.UIPages
{
    public class OnboardingPage : BasePage
    {
        CommonMethods commonPage;

        public OnboardingPage(IWebDriver driver, int pageLoadTimeout)
            : base(driver, pageLoadTimeout)
        {
            commonPage = new CommonMethods(_driver, pageLoadTimeout);
        }

        public OnboardingPage NavigateTo(String _URL)
        {
            _driver.Navigate().GoToUrl(_URL);
            return this;
        }

        //Assert the Please check your inbox message
        public void VerifyWeJustSentYouAnEmailMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.weJustSentYouAnEmail);
        }

        //Assert Resend Email button
        public void VerifyResendEmailbtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.resendEmailBtn);
        }

        //Enter Mailinator Inout Email Address
        public void EnterMailinatorEmail(String email)
        {
            _driver.SafeEnterText(RegistrationUI.mailinatorInputEmail, email);
        }

        //Click Mailinator Go button
        public void ClickGoBtn()
        {
            _driver.SafeClick(RegistrationUI.goButton);
        }

        //Assert the email sender
        public void VerifyEmailSender()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.emailSender);
        }

        //Click the email sender
        public void ClickEmailSender()
        {
            _driver.ClickElementUsingAction(RegistrationUI.emailSender);
        }

        //Assert the email subject
        public void VerifyEmailSubject()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.emailSender);
        }

        //Assert the Verify Your Email button
        public void VerifyYourEmailBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.verifyYourEmailBtn);
        }

        //Get the email link
        public String GetEmailLink()
        {
            return _driver.GetElementAttributeValue(InviteUsersUI.letsRallyBtn, "href");
        }

        //Switch to iframe
        public void SwitchIframe()
        {
            _driver.switchFrameById("publicshowmaildivcontent");
        }

        //Click Let's Go button
        public void ClickLetsGoBtn()
        {
            _driver.SafeClick(RegistrationUI.LetsGoBtn);
        }

        //Assert Welcome User message
        public void VerifyWelcomeUserMsg(String userFirstName)
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.WelcomeUser(userFirstName));
        }

        //Assert Welcome RallyTeam Description message
        public void VerifyWelcomeRallyTeamDescriptionMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.RallyTeamDescription);
        }

        //Assert Get Started button
        public void VerifyGetStartedBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.getStartedBtn);
        }

        //Click Get Started button
        public void ClickGetStartedBtn()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.getStartedBtn, 1);
            _driver.SafeClick(RegistrationUI.getStartedBtn);
        }

        //Assert LinkeDin Confirmation message
        public void VerifyLinkedInConfirmationMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.linkedInConfirmationMsg);
        }

        //Assert Connect with LinkedIn button
        public void VerifyConnectWithLinkedInbtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.linkedInBtn);
        }

        //Assert Skip LinkedIn Option
        public void VerifySkipLinkedIn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.skipLinedIn);
        }
        
        //Click Skip LinkedIn Option
        public void ClickSkipLinkedIn()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.skipLinedIn, 1);
            _driver.SafeClick(RegistrationUI.skipLinedIn);
        }

        //Assert Upload Your Resume message
        public void VerifyUploadResumeMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.uploadResumeMsg);
        }

        //Assert Upload Your Resume button
        public void VerifyUploadYourResumeBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.uploadResumeBtn);
        }

        //Click Upload Your Resume button
        public void ClickUploadYourResumeBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.uploadResumeBtn);
        }

        //Assert Skip Upload Resume Option
        public void VerifySkipUploadResume()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.skipUploadResume);
        }

        //Click Skip Upload Resume Option
        public void ClickSkipUploadResume()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.skipUploadResume, 1);
            _driver.SafeClick(RegistrationUI.skipUploadResume);
        }

        //Assert What Do You Work In message
        public void VerifyWhatDoYouWorkInMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.whatDoYouWorkIn);
        }

        //Assert Work Drop-Down
        public void VerifyWorkDropDown()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.workDropDown);
        }

        //Select Work Drop-Down
        public void SelectWorkDropDown(String work)
        {
            _driver.SelectDropDownOption(work, RegistrationUI.workDropDown);
        }

        //Assert Continue button
        public void VerifyContinueBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.continueBtn);
        }

        //Click Continue button
        public void ClickContinueBtn()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.continueBtn, 1);
            _driver.SafeClick(RegistrationUI.continueBtn);
        }

        //Assert Are these your top three skills? message
        public void VerifyAreTheseYourTopSkillsMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.areTheseYourTopSkills);
        }

        //Assert Skills Div
        public void VerifySkillsDiv()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.skillsDiv);
        }

        //Assert Continue Skills button
        public void VerifyContinueSkillsBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.continueSkillsBtn);
        }

        //Click Continue Skills button
        public void ClickContinueSkillsBtn()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.continueSkillsBtn, 1);
            _driver.SafeClick(RegistrationUI.continueSkillsBtn);
        }

        //Count the number of skills and fail if more than 3
        public void CountSkillsAndFailIfMoreThanThree()
        {
            IWebElement ulItems = _driver.FindElement(RegistrationUI.AllSkills);
            IList<IWebElement> liItems = ulItems.FindElements(By.TagName("li"));
            int count = liItems.Count;
            Console.WriteLine("No Of Li items: " + count);
            if (count >= 4)
            {
                _assertHelper.AssertFailTestCase();
            }
        }

        //Assert What are you interested in? message
        public void VerifyWhatAreYouInterestedInMsg()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.whatAreYouInterestedInMsg);
        }

        //Assert Interests Div
        public void VerifyInterestsDiv()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.interestsDiv);
        }

        //Assert Lets Get You Matched button
        public void VerifyLetsGetYouMatchedBtn()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.letsGetYouMatchedBtn);
        }

        //Click Lets Get You Matched button
        public void ClickLetsGetYouMatchedBtn()
        {
            _driver.WaitForElementAvailableAtDOM(RegistrationUI.letsGetYouMatchedBtn, 1);
            _driver.SafeClick(RegistrationUI.letsGetYouMatchedBtn);
        }

        //Enter Interests Input
        public void EnterInterests(String interest)
        {
            _driver.SafeEnterText(RegistrationUI.interestsInput, interest);
        }

        //Assert Marketplace tab
        public void VerifyMarketplaceTab()
        {
            _assertHelper.AssertElementDisplayed(RegistrationUI.marketplace);
        }


























    }
}
