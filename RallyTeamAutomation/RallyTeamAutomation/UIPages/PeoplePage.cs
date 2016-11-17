using OpenQA.Selenium;
using RallyTeam.Util;
using RallyTeam.UILocators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace RallyTeam.UIPages
{
    public class PeoplePage : BasePage
    {
        CommonMethods commonPage;

        public PeoplePage(IWebDriver driver, int pageLoadTimeout)
            : base(driver, pageLoadTimeout)
        {
            commonPage = new CommonMethods(_driver, pageLoadTimeout);
        }

        //Press Enter Key
        public void PressEnterKey()
        {
            _driver.PressKeyBoardEnter();
        }

        //Press Tab Key
        public void PressTabKey()
        {
            _driver.PressKeyBoardTab();
        }

        //Verify People menu option
        public void VerifyPeopleMenuOption()
        {
            _assertHelper.AssertElementDisplayed(DashboardUI.sideNavBar("People"));
        }

        //Click on People menu option
        public void ClickPeopleMenu()
        {
            _driver.WaitForElementAvailableAtDOM(DashboardUI.sideNavBar("People"), 1);
            _driver.SafeClick(DashboardUI.sideNavBar("People"));
        }

        //Assert Search text box
        public void VerifySearchBox()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.searchBox);
        }

        //Assert Adcance search link text box
        public void VerifyAdvanceSearchLink()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.advanceLink);
        }

        //Enter Search text box
        public void EnterSearchBox(String search)
        {
            _driver.WaitForElementAvailableAtDOM(PeopleUI.searchBox, 1);
            _driver.SafeEnterText(PeopleUI.searchBox, search);
        }

        //Assert the user container displayed
        public void VerifyUserContainer()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.userContainer);
        }

        //Move to user container
        public void MoveToUserContainer()
        {
            _driver.MoveToElementUsingAction(PeopleUI.userContainer);
        }

        //Assert the Message button
        public void VerifyMessageBtn()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.messageBtn);
        }

        //Assert the Message button not displayed
        public void VerifyMessageBtnNotDisplayed()
        {
            _assertHelper.AssertElementNotDisplayed(PeopleUI.messageBtn);
        }

        //Press the Message button
        public void ClickMessageBtn()
        {
            _driver.SafeClick(PeopleUI.messageBtn);
        }

        //Assert the View Profile button
        public void VerifyViewProfileBtn()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.viewProfileBtn);
        }

        //Assert the New Message Window button
        public void VerifyNewMessageWindow()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.newMessageWindow);
        }

        //Enter message in text area
        public void EnterMessage(String message)
        {
            _driver.SafeEnterText(PeopleUI.msgTextAera, message);
        }

        //Press the Send button
        public void ClickSendBtn()
        {
            _driver.SafeClick(PeopleUI.sendMessageBtn);
        }

        //Assert the New Message Window button
        public void VerifyMessagConversationWindow()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.messageConversationWindow);
        }

        //Assert the Message Posted
        public void VerifyNewMessagwPosted(String message)
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.messagePosted(message));
        }

        //Press the View Profile button
        public void ClickViewProfileBtn()
        {
            _driver.SafeClick(PeopleUI.viewProfileBtn);
        }

        //Assert the User Profile User Name
        public void VerifyUserName(String userName)
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.userName(userName));
        }

        //Assert the User Profile Messag button
        public void VerifyUserProfileMessageBtn()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.userProfileMessageBtn);
        }

        //Assert the User Profile About Me
        public void VerifyAboutMe()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.aboutMe);
        }

        //Assert the User Profile Skills & Endorsements
        public void VerifySkillsEndorsements()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.skillsANdEndorsements);
        }

        //Assert the User Profile Industry/Domain Expertise
        public void VerifyIndustryDomainExpertise()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.industryDomain);
        }

        //Assert the User Profile Languages
        public void VerifyLanguages()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.languages);
        }

        //Assert the User Profile Interests
        public void VerifyInterests()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.interests);
        }

        //Assert the User Profile Projects
        public void VerifyProjects()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.projects);
        }

        //Assert Adcance search link text box
        public void ClickAdvanceSearchLink()
        {
            _driver.SafeClick(PeopleUI.advanceLink);
        }

        //Assert the Advance Search Name
        public void VerifyName()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.name);
        }

        //Enter the Advance Search Name
        public void EnterAdvanceSearchName(String name)
        {
            _driver.SafeEnterText(PeopleUI.name, name);
        }

        //Assert the Advance Search Skills Needed
        public void VerifySkillsNeeded()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.skillsNeeded);
        }

        //Assert the Advance Search Job Function
        public void VerifyJobFunction()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.jobFunction);
        }

        //Assert the Advance Search Location
        public void VerifyLocation()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.location);
        }

        //Assert the Advance Search Industry/Domain Expertise
        public void VerifyAdvSearchIndustryDomainExpertise()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.advSearchIndustryDomain);
        }

        //Assert the Advance Search Endorsed By
        public void VerifyEndorsedBy()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.endorsedBy);
        }

        //Assert the Advance Search Availability
        public void VerifyAvailability()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.availability);
        }

        //Assert the Advance Search Type
        public void VerifyType()
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.type);
        }

        //Click the User Profile Messag button
        public void ClickUserProfileMessageBtn()
        {
            _driver.SafeClick(PeopleUI.userProfileMessageBtn);
        }

        //Assert User Name search is displayed
        public void VerifyUserContainerUserName(String userName)
        {
            _assertHelper.AssertElementDisplayed(PeopleUI.userContainerUserName(userName));
        }

        //Click the Advance Search button
        public void ClickAdvanceSearchBtn()
        {
            _driver.SafeClick(PeopleUI.searchBtn);
        }
    }
}
