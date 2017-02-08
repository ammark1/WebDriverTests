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
    public class PostProjectPage : BasePage
    {
        CommonMethods commonPage;

        public PostProjectPage(IWebDriver driver, int pageLoadTimeout)
            : base(driver, pageLoadTimeout)
        {
            commonPage = new CommonMethods(_driver, pageLoadTimeout);
        }

        //Verify Post a Project option
        public void VerifyPostProjectOption()
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.postAProjectTab);
        }

        //Click on Projects menu option
        public void ClickPostProject()
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.postAProjectTab, 1);
            _driver.SafeClick(PostProjectUI.postAProjectTab);
        }

        //Enter Project Name
        public void EnterProjectName(String projectName)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.projectName, 1);
            _driver.SafeEnterText(PostProjectUI.projectName, projectName);
        }

        //Enter Project Description
        public void EnterProjectDescription(String projectDescription)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.projectDesc, 1);
            _driver.SafeEnterText(PostProjectUI.projectDesc, projectDescription);
        }

        //Enter Project Location
        public void EnterProjectLocation(String projectLocation)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.projectLocation, 1);
            _driver.SafeEnterText(PostProjectUI.projectLocation, projectLocation);
        }

        //Enter Members Needed
        public void EnterMembersNeeded(String noOfMembers)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.membersNeeded, 1);
            _driver.SafeEnterText(PostProjectUI.membersNeeded, noOfMembers);
        }

        //Enter Skills Needed
        public void EnterSkillsNeeded(String skillsNeeded)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.skillsNeeded, 1);
            _driver.SafeEnterText(PostProjectUI.skillsNeeded, skillsNeeded);
        }

        //Enter Member Name
        public void EnterMemberName(String memberName)
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.specificallyAddMember, 1);
            _driver.SafeEnterText(PostProjectUI.specificallyAddMember, memberName);
        }

        //Click Create button
        public void ClickOnCreateProjectBtn()
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.createBtn, 1);
            _driver.SafeClick(PostProjectUI.createBtn);
        }

        //Verify the About tab on Projects Page
        public void VerifyAboutTabOnPage()
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.aboutTab);
        }

        //Verify the Suggested Member Name
        public void VerifySuggestedMemberName(String suggestedMemberName)
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.suggestedMemberName(suggestedMemberName));
        }

        //Verify the Update Metrics Button
        public void VerifyUpdateMetricsBtn()
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.updateMetricsBtn);
        }

        //Press Complete Project window
        public void ClickCompleteProjectWindow()
        {
            _driver.SafeClick(ProjectsUI.completeProjectWindow);
        }

        //Press Mark Complete button at Complete Project window
        public void ClickMarkComplete()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.completeProjMarkComplete, 1);
            _driver.SafeClick(ProjectsUI.completeProjMarkComplete);
        }

        //Select Closed option from All Projects Dropdown
        public void SelectAllProjectsClosed()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.ProjTypeClosed, 1);
            _driver.ClickElementUsingAction(ProjectsUI.ProjTypeClosed);
        }
        
        //Click on Delete Project Icon
        public void ClickDeleteProjectIcon()
        {
            _driver.ClickElementUsingJS(PostProjectUI.deleteProjectIcon);
        }

        //Verify No Button from the Delete Group Window
        public void VerifyDeleteProjectWindow()
        {
            _assertHelper.AssertElementDisplayed(ProjectsUI.deleteProjectWindow);
        }

        //Verify No Button from the Delete Group Window
        public void VerifyDeleteProjectWindowNoBtn()
        {
            _assertHelper.AssertElementDisplayed(ProjectsUI.deleteProjectWindowNoBtn);
        }

        //Verify Yes Button from the Delete Group Window
        public void VerifyDeleteProjectWindowYesBtn()
        {
            _assertHelper.AssertElementDisplayed(ProjectsUI.deleteProjectWindowYesBtn);
        }

        //Press No Button from the Delete Project Window
        public void PressDeleteProjectWindowNoBtn()
        {
            _driver.SafeClick(ProjectsUI.deleteProjectWindowNoBtn);
        }

        //Press Yes Button from the Delete Project Window
        public void PressDeleteProjectWindowYesBtn()
        {
            _driver.SafeClick(ProjectsUI.deleteProjectWindowYesBtn);
        }

        //Select a value from Stratus dropdown
        public void SelectStatusDropDown(String option)
        {
            _driver.SelectDropDownOption(option, ProjectsUI.statusDropDown);
        }

        //Click Stratus dropdown
        public void ClickStatusDropDown()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.statusDropDown, 1);
            _driver.SafeClick(ProjectsUI.statusDropDown);
        }

        //Edit Project Name
        public void EditProjectName(String editProjectName)
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.nameField, 1);
            _driver.SafeEnterText(ProjectsUI.nameField, editProjectName);
        }

        //Select Project Leader
        public void SelectOptionFromProjectOwner(String dropdwnoptn)
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.projectOwner, 1);
            _driver.SafeSelectDropDownText(ProjectsUI.projectOwner, dropdwnoptn);
        }

        //Press the Add Member Icon for Project
        public void ClickAddMemberIcon()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.addMemberIcon, 1);
            _driver.SafeClick(ProjectsUI.addMemberIcon);
        }

        //Enter Project Member Email
        public void EnterProjectMemberEmail(String memberEmail)
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.addSomeoneText, 1);
            _driver.SafeEnterText(ProjectsUI.addSomeoneText, memberEmail);
        }

        //Select user from suggestion list
        public void SelectUserfromSuggestion(String SuggItem)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberSuggList(SuggItem), 1);
            _driver.SafeClick(GroupsUI.addMemberSuggList(SuggItem));
        }

        //Press Project Add Member Window Done button
        public void ClickAddProjectMemberDoneBtn()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.doneBtn, 1);
            _driver.SafeClick(ProjectsUI.doneBtn);
        }

        //Verify the Added Project Member confirmation message
        public void VerifyAddedMemberConfMsg()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.addMemberConfirmationMsg, 1);
            _assertHelper.AssertElementDisplayed(ProjectsUI.addMemberConfirmationMsg);
        }

        //Press the Added Project Member remove icon
        public void ClickAddedMemberRemoveIcon()
        {
            _driver.WaitForElementAvailableAtDOM(PostProjectUI.addedMemberRemoveIcon, 1);
            _driver.ClickElementUsingJS(PostProjectUI.addedMemberRemoveIcon);
        }

        //Press the Remove Project Member Window Yes Button
        public void PressRemoveMemberYesBtn()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.removeMemberYesBtn, 1);
            _driver.SafeClick(ProjectsUI.removeMemberYesBtn);
        }

        //Assert Project Member is deleted from the Project
        public void VerifyProjectMemberNameIsDeleted(String memberName)
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.VerifyProjectMemberName(memberName), 1);
            _assertHelper.AssertElementNotDisplayed(ProjectsUI.VerifyProjectMemberName(memberName));
        }

        //Enter Project Name in Search field
        public void SearchProjectName(String projectName)
        {
            _driver.SafeEnterText(MarketPlaceUI.searchText, projectName);
        }

        //Press Search button
        public void ClickSearchBtn()
        {
            _driver.SafeClick(MarketPlaceUI.searchBtn);
        }

        //Click the Project on Projects Page
        public void ClickProjectNameOnPage(String projectName)
        {
            _driver.ClickElementUsingJS(ProjectsUI.ProjectNameOnPage(projectName));
        }

        //Press Request To Join button
        public void ClickRequestToJoinBtn()
        {
            _driver.ClickUsingSendKeys(ProjectsUI.requestToJoinBtn);
        }

        //Verify Request Sent button
        public void AsssertRequestSentBtn()
        {
            _driver.WaitForElementAvailableAtDOM(ProjectsUI.requestSentBtn, 1);
            _assertHelper.AssertElementDisplayed(ProjectsUI.requestSentBtn);
        }

        //Click Private Project checkbox
        public void ClickPrivateProjectCheckBox()
        {
            _driver.SafeClick(PostProjectUI.privateProjectCheckbox);
        }

        //Verify Private icon for Private Project
        public void AssertPrivateIcon()
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.privateProjectIcon);
        }

        //Click Private icon for Private Project
        public void ClickPrivateIcon()
        {
            _driver.SafeClick(PostProjectUI.privateProjectIcon);
        }

        //Verify Project is not displayed message
        public void AssertProjectNotDisplayedMsg()
        {
            _assertHelper.AssertElementDisplayed(PostProjectUI.noProjectDisplayedMsg);
        }       


    }
}
