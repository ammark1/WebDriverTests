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

namespace RallyTeam.TestScripts
{
    [TestFixture]
    [Category("People"), Category("Nightly")]
    public class PeopleTest : BaseTest
    {
        static ReadData readPeople = new ReadData("People");

        //SignIn
        private void SignInDifferentUser()
        {
            String userName = readPeople.GetValue("SignInDifferentUser", "userName");
            String password = readPeople.GetValue("SignInDifferentUser", "password");
            authenticationPage.SetUserName(userName);
            authenticationPage.SetPassword(password);
            authenticationPage.ClickOnLoginButton();
        }

        [Test]
        public void People_001_VerifyPeopleOption()
        {
            Global.MethodName = "People_001_VerifyPeopleOption";
            Thread.Sleep(2000);
            peoplePage.VerifyPeopleMenuOption();
            log.Info("Verify People menu icon");
        }

        [Test]
        public void People_002_VerifyPeopleDashboard()
        {
            Global.MethodName = "People_002_VerifyPeopleDashboard";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Verify the Search box is displayed
            peoplePage.VerifySearchBox();
            log.Info("Verify the Search text.");
            Thread.Sleep(2000);

            //Verify the Advance Search Link is displayed
            peoplePage.VerifyAdvanceSearchLink();
            log.Info("Verify the Advance Search Link.");
            Thread.Sleep(2000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Verify User container is displayed
            peoplePage.VerifyUserContainer();
            log.Info("Verify User Container is displayed.");
            Thread.Sleep(2000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Verify Message button is displayed
            peoplePage.VerifyMessageBtn();
            log.Info("Verify Message button is displayed.");
            Thread.Sleep(2000);

            //Verify View Profile button is displayed
            peoplePage.VerifyViewProfileBtn();
            log.Info("Verify View Profile button is displayed.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_003_ClickMessageAndVerify()
        {
            Global.MethodName = "People_003_ClickMessageAndVerify";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Click Message button
            peoplePage.ClickMessageBtn();
            log.Info("Click on Message button.");
            Thread.Sleep(3000);

            //Assert the New Message Window is displayed
            peoplePage.VerifyNewMessageWindow();
            log.Info("Verify New Message Window.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_004_SendMessageAndVerify()
        {
            Global.MethodName = "People_004_SendMessageAndVerify";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Click Message button
            peoplePage.ClickMessageBtn();
            log.Info("Click on Message button.");
            Thread.Sleep(3000);

            //Enter the message in the text area
            String messageText = readPeople.GetValue("People", "messageText");
            peoplePage.EnterMessage(messageText);
            log.Info("Enter New Message in the text area.");
            Thread.Sleep(2000);

            //Click on Send button
            peoplePage.ClickSendBtn();
            log.Info("Click on Send button.");
            Thread.Sleep(3000);

            //Assert the Message Conversation Window is displayed
            peoplePage.VerifyMessagConversationWindow();
            log.Info("Verify Message Conversation Window.");
            Thread.Sleep(2000);

            //Assert the Message is posted
            peoplePage.VerifyNewMessagwPosted(messageText);
            log.Info("Verify New Message is Posted.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_006_ClickViewProfileAndVerify()
        {
            Global.MethodName = "People_006_ClickViewProfileAndVerify";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Click View Profile button
            peoplePage.ClickViewProfileBtn();
            log.Info("Click on Message button.");
            Thread.Sleep(3000);

            //Assert the User Profile User Name
            peoplePage.VerifyUserName(searchUser);
            log.Info("Verify User Profile User Name.");
            Thread.Sleep(2000);

            //Assert the User Profile Message button
            peoplePage.VerifyUserProfileMessageBtn();
            log.Info("Verify User Profile Message button.");
            Thread.Sleep(2000);

            //Assert the User Profile About Me
            peoplePage.VerifyAboutMe();
            log.Info("Verify User Profile About Me.");
            Thread.Sleep(2000);

            //Assert the User Profile Skills & Endorsements
            peoplePage.VerifySkillsEndorsements();
            log.Info("Verify User Profile Skills & Endorsements.");
            Thread.Sleep(2000);

            //Assert the User Profile Industry/Domain Expertise
            peoplePage.VerifyIndustryDomainExpertise();
            log.Info("Verify User Profile Industry/Domain Expertise.");
            Thread.Sleep(2000);

            //Assert the User Profile Languages
            peoplePage.VerifyLanguages();
            log.Info("Verify User Profile Languages.");
            Thread.Sleep(2000);

            //Assert the User Profile Interests
            peoplePage.VerifyInterests();
            log.Info("Verify User Profile Interests.");
            Thread.Sleep(2000);

            //Assert the User Profile Projects
            peoplePage.VerifyProjects();
            log.Info("Verify User Profile Projects.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_009_VerifyAdvanceSearchFields()
        {
            Global.MethodName = "People_009_VerifyAdvanceSearchFields";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Click the Advance Search option
            peoplePage.ClickAdvanceSearchLink();
            log.Info("Clickthe Advance Search hyperlink.");
            Thread.Sleep(2000);

            //Assert the Advance Search Name
            peoplePage.VerifyName();
            log.Info("Verify Advance Search Name.");
            Thread.Sleep(1000);

            //Assert the Advance Search Skills Needed
            peoplePage.VerifySkillsNeeded();
            log.Info("Verify Advance Search Skills Needed.");
            Thread.Sleep(1000);

            //Assert the Advance Search Job Function
            peoplePage.VerifyJobFunction();
            log.Info("Verify Advance Search Job Function.");
            Thread.Sleep(1000);

            //Assert the Advance Search Location
            peoplePage.VerifyLocation();
            log.Info("Verify Advance Search Location.");
            Thread.Sleep(1000);

            //Assert the Advance Industry/Domain Expertise 
            peoplePage.VerifyAdvSearchIndustryDomainExpertise();
            log.Info("Verify Advance Search Industry/Domain Expertise.");
            Thread.Sleep(1000);

            //Assert the Advance Search Endorsed By
            peoplePage.VerifyEndorsedBy();
            log.Info("Verify Advance Search Endorsed By.");
            Thread.Sleep(1000);

            //Assert the Advance Search Availability
            peoplePage.VerifyAvailability();
            log.Info("Verify Advance Search Availability.");
            Thread.Sleep(1000);

            //Assert the Advance Search Type
            peoplePage.VerifyType();
            log.Info("Verify Advance Search Type.");
            Thread.Sleep(1000);
        }

        [Test]
        public void People_012_VerifyLoggedInUser()
        {
            Global.MethodName = "People_012_VerifyLoggedInUser";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Get UserName
            String userName = commonPage.GetUserName();

            //Enter the Search text
            peoplePage.EnterSearchBox(userName);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Verify Message button is not displayed
            peoplePage.VerifyMessageBtnNotDisplayed();
            log.Info("Verify Message button is not displayed.");
            Thread.Sleep(2000);

            //Verify View Profile button is displayed
            peoplePage.VerifyViewProfileBtn();
            log.Info("Verify View Profile button.");
            Thread.Sleep(2000);

            //Click View Profile button
            peoplePage.ClickViewProfileBtn();
            log.Info("Click on Message button.");
            Thread.Sleep(3000);

            //Assert the User Profile User Name
            peoplePage.VerifyUserName(userName);
            log.Info("Verify User Profile User Name.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_018_ClickUserProfileMessageAndVerify()
        {
            Global.MethodName = "People_018_ClickUserProfileMessageAndVerify";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Click View Profile button
            peoplePage.ClickViewProfileBtn();
            log.Info("Click on View Profile button.");
            Thread.Sleep(3000);

            //Click User Profile Message button
            peoplePage.ClickUserProfileMessageBtn();
            log.Info("Click on User Profile Message button.");
            Thread.Sleep(3000);

            //Assert the New Message Window is displayed
            peoplePage.VerifyNewMessageWindow();
            log.Info("Verify New Message Window.");
            Thread.Sleep(2000);
        }

        [Test]
        public void People_019_SendUserProfileMessageAndVerify()
        {
            Global.MethodName = "People_019_SendUserProfileMessageAndVerify";
            //Click People menu option
            Thread.Sleep(2000);
            peoplePage.ClickPeopleMenu();
            log.Info("Click the People menu option.");
            Thread.Sleep(3000);

            //Enter the Search text
            String searchUser = readPeople.GetValue("People", "searchUser");
            peoplePage.EnterSearchBox(searchUser);
            log.Info("Enter the Search text.");
            Thread.Sleep(1000);

            //Press enter key
            peoplePage.PressEnterKey();
            Thread.Sleep(3000);

            //Move to User Container
            peoplePage.MoveToUserContainer();
            log.Info("Move to user container.");
            Thread.Sleep(2000);

            //Click View Profile button
            peoplePage.ClickViewProfileBtn();
            log.Info("Click on View Profile button.");
            Thread.Sleep(3000);

            //Click User Profile Message button
            peoplePage.ClickUserProfileMessageBtn();
            log.Info("Click on User Profile Message button.");
            Thread.Sleep(3000);

            //Enter the message in the text area
            String messageText = readPeople.GetValue("People", "messageText");
            peoplePage.EnterMessage(messageText);
            log.Info("Enter New Message in the text area.");
            Thread.Sleep(2000);

            //Click on Send button
            peoplePage.ClickSendBtn();
            log.Info("Click on Send button.");
            Thread.Sleep(3000);

            //Assert the Message Conversation Window is displayed
            peoplePage.VerifyMessagConversationWindow();
            log.Info("Verify Message Conversation Window.");
            Thread.Sleep(2000);

            //Assert the Message is posted
            peoplePage.VerifyNewMessagwPosted(messageText);
            log.Info("Verify New Message is Posted.");
            Thread.Sleep(2000);
        }
    }
}