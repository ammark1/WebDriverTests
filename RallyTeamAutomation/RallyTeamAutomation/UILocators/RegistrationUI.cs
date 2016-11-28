using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace RallyTeam.UILocators
{
    public static class RegistrationUI
    {
        public readonly static By logInBtn = By.XPath("//button[text()='Log in']");
        public readonly static By loginDiv = By.XPath("//div[contains(text(), 'Log in with')]");
        public readonly static By forgotPwd = By.XPath("//a[text()='Forgot password?']");
        public readonly static By registrationLogInBtn = By.XPath("//button[text()='Log in']");
        public readonly static By forgotPwdPage = By.XPath("//div[contains(text(), 'Forgot your password?')]");
        public readonly static By submitBtn = By.XPath("//button[text()='Submit']");
        public readonly static By goBackLink = By.XPath("//a[text()='Go Back']");

        public readonly static By workEmail = By.Name("email");
        public readonly static By firstName = By.Name("firstName");
        public readonly static By lastName = By.Name("lastName");
        public readonly static By signUpButton = By.XPath("//button[text()='Sign Up']");
        public readonly static By linkedinIcon = By.XPath("//ul[@class='social-list']//li[1]");
        public readonly static By googleIcon = By.XPath("//ul[@class='social-list']//li[2]");
        public readonly static By outlookIcon = By.XPath("//ul[@class='social-list']//li[3]");
        public readonly static By termsOfUseLink = By.XPath("//a[text()='Terms of Use']");
        public readonly static By privacyPolicyLink = By.XPath("//a[text()='Privacy Policy']");
        public readonly static By createPassword = By.XPath("//form[contains(@class, 'form-horizontal')]//input[@name='password']");
        public readonly static By confirmPassword = By.XPath("//form[contains(@class, 'form-horizontal')]//input[@name='confirmPassword']");
        public readonly static By nextButton = By.XPath("//form[contains(@class, 'form-horizontal')]//button[contains(text(), 'Next')]");
        public readonly static By duplicateEmailErrorMessage = By.XPath("//div[contains(text(), 'We thought you looked familiar. This email address has already been registered. Please try another one or log-in to enter.')]");
        public readonly static By errorMessage = By.XPath("//div[contains(text(), 'Please fill out the missing info.')]");
        public readonly static By createPwdEmpty = By.XPath("//div[contains(text(), 'Password does not meet the criteria.')]");
        public readonly static By shortPwdError = By.XPath("//div[contains(text(), 'Password does not meet the criteria.')]");
        public readonly static By differentPwdError = By.XPath("//div[contains(text(), 'Passwords do not match. Please try again.')]");        
        public readonly static By confirmPwdEmpty = By.XPath("//div[contains(text(), 'Passwords do not match. Please try again.')]");
        public readonly static By invalidEmailErrorMessage = By.XPath("//div[contains(text(), 'Sorry, your current organization or email address is not valid')]");
        public readonly static By resendEmailBtn = By.XPath("//button[text()='Resend Email']");
        public readonly static By notYouLink = By.XPath("//a[text()='not you?']");

        /*-----For onboarding purpose-----*/
        public static By completeEmail(String variable)
        {
            return By.XPath("//div[contains(text(), '"+variable+"')]");
        }
        public readonly static By weJustSentYouAnEmail = By.XPath("//div[contains(text(), 'We just sent you an email to the following address:')]");
        public readonly static By mailinatorInputEmail = By.XPath("//input[@id= 'inboxfield']");
        public readonly static By goButton = By.XPath("//button[contains(text(), 'Go!')]");
        public readonly static By emailSender = By.XPath("//div[contains(text(), 'Rallyteam')]");
        public readonly static By emailSubject= By.XPath("//div[contains(text(), '360logica invites you to our exclusive network')]");
        public readonly static By iframe = By.XPath("//iframe[@id= 'publicshowmaildivcontent']");
        public readonly static By verifyYourEmailBtn = By.XPath("//a[contains(text(),'Verify Your Email')]");
        //public readonly static By emailLink = By.XPath("//table[@class= 'twelve columns']//a[@class= 'need-a-link']");
        public readonly static By LetsGoBtn = By.XPath("//button[@type='submit']");
        public static By WelcomeUser(String variable)
        {
            return By.XPath("//div[contains(text(), 'Welcome "+variable+"!')]");
        }
        public readonly static By RallyTeamDescription = By.XPath("//div[contains(text(), 'Rallyteam is a platform that connects people to opportunities based on skills, expertise and interests.')]");
        public readonly static By getStartedBtn = By.XPath("//button[contains(text(), 'Get Started')]");
        public readonly static By linkedInConfirmationMsg = By.XPath("//div[contains(text(), 'Do you want to connect your LinkedIn profile?')]");
        public readonly static By linkedInBtn = By.XPath("//button[contains(@class, 'linkedinsso')]");
        public readonly static By skipLinedIn = By.XPath("//a[contains(text(), 'SKIP')]");
        public readonly static By uploadResumeMsg = By.XPath("//div[contains(text(), 'Would you like to upload your resume?')]");
        public readonly static By uploadResumeBtn = By.XPath("//button[contains(@class, 'resume')]");
        public readonly static By skipUploadResume = By.XPath("//a[contains(text(), 'SKIP')]");
        public readonly static By whatDoYouWorkIn = By.XPath("//div[contains(text(), 'What do you work in?')]");
        public readonly static By workDropDown = By.XPath("//select[@name= 'jobfunction']");
        public readonly static By continueBtn = By.XPath("//button[contains(text(), 'Continue')]");
        public readonly static By areTheseYourTopSkills = By.XPath("//div[contains(text(), 'Are these your top three skills?')]");
        public readonly static By skillsDiv = By.XPath("//div[contains(@class, 'rt-tags-input-container')]");
        public readonly static By AllSkills = By.XPath("//ul[contains(@class, 'tag-list')]");
        public readonly static By continueSkillsBtn = By.XPath("//button[contains(text(), 'Continue')]");
        public readonly static By whatAreYouInterestedInMsg = By.XPath("//div[contains(text(), 'What are you interested in?')]");
        public readonly static By interestsDiv = By.XPath("//div[contains(@class, 'rt-tags-input-container')]");
        public readonly static By interestsInput = By.XPath("//tags-input[@id= 'interested-skills']//input[contains(@class, 'input')]");
        public readonly static By letsGetYouMatchedBtn = By.XPath("//button[@type='submit']");
        public readonly static By marketplace = By.XPath("//a[text()= 'MARKETPLACE']");










    }
}
