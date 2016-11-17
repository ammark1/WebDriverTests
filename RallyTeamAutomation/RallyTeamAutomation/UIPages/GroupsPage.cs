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
    public class GroupsPage : BasePage
    {
        CommonMethods commonPage;

        public GroupsPage(IWebDriver driver, int pageLoadTimeout)
            : base(driver, pageLoadTimeout)
        {
            commonPage = new CommonMethods(_driver, pageLoadTimeout);
        }

        //Verify Groups menu option
        public void VerifyGroupMenuOption() 
        {
            _assertHelper.AssertElementDisplayed(DashboardUI.sideNavBar("Groups"));
        }

        //Press on Group's About tab
        public void ClickGroupAboutTab()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.aboutTab, 1);
            _driver.SafeClick(GroupsUI.aboutTab);
        }

        //Click on Groups menu option
        public void clickGroupsMenu()
        {
            _driver.WaitForElementAvailableAtDOM(DashboardUI.sideNavBar("Groups"), 1);
            //IWebElement button = _driver.FindElement(AuthenticationUI.signInBtn);
            _driver.SafeClick(DashboardUI.sideNavBar("Groups"));
        }

        //Verify Group Leader selected option
        public void GetGroupLeaderSelectedOption(String groupLeader)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupLeader, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupLeader);
        }

        //Click on 'Add New Group' button
        public void clickOnAddNewGroupButton()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addNewGroupBtn, 1);
            _driver.SafeClick(GroupsUI.addNewGroupBtn);
        }

        //Assert the Add group Window
        public void assertAddGroupDialog()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addGroupsDlg, 1);
            _driver.SafeClick(GroupsUI.addGroupsDlg);
        }

        //Assert Group Upload Photo option
        public void assertGroupUploadPhoto()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupUploadPhoto, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupUploadPhoto);
        }

        //Click Group Upload Photo option
        public void ClicktGroupUploadPhoto()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupUploadPhoto, 1);
            _driver.SafeClick(GroupsUI.groupUploadPhoto);
        }

        //Click Group Photo Upload Save Button
        public void ClicktGroupUploadPhotoSaveBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupUploadPhotoSaveBtn, 1);
            _driver.SafeClick(GroupsUI.groupUploadPhotoSaveBtn);
        }

        //Click Group Photo Area
        public void ClickGroupPhotoArea()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupPhotoArea, 1);
            _driver.SafeClick(GroupsUI.groupPhotoArea);
        }

        //Assert Group Change Photo option
        public void assertGroupChangePhoto()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupChangePhoto, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupChangePhoto);
        }

        //Click Group Change Photo option
        public void ClicktGroupChangePhoto()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupChangePhoto, 1);
            _driver.SafeClick(GroupsUI.groupChangePhoto);
        }

        //Enter Group Name
        public void enterNewGroupName(String groupName)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.name, 1);
            _driver.SafeEnterText(GroupsUI.name, groupName);
        }

        //Enter Group Snippet
        public void enterNewGroupSnippet(String groupSnippet)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.snippet, 1);
            _driver.SafeEnterText(GroupsUI.snippet, groupSnippet);
        }

        //Enter Group Description
        public void enterNewGroupDescription(String groupDescription)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.description, 1);
            _driver.SafeEnterText(GroupsUI.description, groupDescription);
        }

        //Select Group Leader
        public void selectOptionFromGroupLeader(String dropdwnoptn)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupLeader, 1);
            _driver.SafeClick(GroupsUI.groupLeader);
            _driver.WaitForElementAvailableAtDOM(GroupsUI.droDownMenu(dropdwnoptn), 1);
            _driver.SafeClick(GroupsUI.droDownMenu(dropdwnoptn));
        }

        //Select Visibility
        public void selectVisibility(String radioOption)
        {
		    if(radioOption.Equals("Public")){
                _driver.WaitForElementAvailableAtDOM(GroupsUI.visibilityPublic, 1);
                _driver.SafeClick(GroupsUI.visibilityPublic);
            }
		    if(radioOption.Equals("Private")){
                _driver.WaitForElementAvailableAtDOM(GroupsUI.visibilityPrivate, 1);
                _driver.SafeClick(GroupsUI.visibilityPrivate);
            }
        }

        //Click Create button
        public void clickOnCreateButton()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.createBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.createBtn);
            _driver.SafeClick(GroupsUI.createBtn);
        }

        //Click Cancel button
        public void ClickOnCancelButton()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.cancelBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.cancelBtn);
            _driver.SafeClick(GroupsUI.cancelBtn);
        }

        //Click Settings option
        public void ClickSettingsOption()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.settings, 1);
            _driver.SafeClick(GroupsUI.settings);
        }

        //Assert Settings drop-down values
        public void GetSettingsOptionsValues(String optionValue)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.settingsOptions(optionValue), 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.settingsOptions(optionValue));
        }

        //Click Settings drop-down values
        public void ClickSettingsOptionsValues(String optionValue)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.settingsOptions(optionValue), 1);
            _driver.SafeClick(GroupsUI.settingsOptions(optionValue));
        }

        //Click Add Member Icon
        public void ClickOnAddMemberIcon()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberIcon, 1);
            _driver.SafeClick(GroupsUI.addMemberIcon);
        }

        //Assert the Add Group Member Window
        public void AssertAddGroupMemberDialog()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberWindow, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.addMemberWindow);
        }           

        //Assert the Add Group Member Button
        public void AssertAddWindowAddButton()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addWindowAddButton, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.addWindowAddButton);
        }

        //Enter Group Member Email
        public void EnterGroupMemberEmail(String memberEmail)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberText, 1);
            _driver.SafeEnterText(GroupsUI.addMemberText, memberEmail);
        }

        //Select user from suggestion list
        public void SelectUserfromSuggestion(String SuggItem)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberSuggList(SuggItem), 1);
            _driver.SafeClick(GroupsUI.addMemberSuggList(SuggItem));
        }

        //Click on Add Group Member Button
        public void ClickAddWindowAddButton()
        {
            _driver.SafeClick(GroupsUI.addWindowAddButton);
        }

        //Verify the Added Group Member confirmation message
        public void VerifyAddedMemberConfMsg(String messageText)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.addMemberConfirmationMsg(messageText), 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.addMemberConfirmationMsg(messageText));
        }

        //Press Add Member Window Close Icon
        public void ClickAddWindMemberWindowCloseIcon()
        {
            _driver.SafeClick(GroupsUI.addMemberWindowCloseIcon);
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

        //Assert the Manage Group Member Window
        public void AssertManageGroupMemberDialog()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberWindow, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.manageMemberWindow);
        }

        //Press Manage Member Window Second Member Cross Icon
        public void ClickManageMemberSecondCrossIcon()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberSecondCrossIcon, 1);
            _driver.SafeClick(GroupsUI.manageMemberSecondCrossIcon);
        }

        //Assert Manage Member Window Remove Button
        public void AssertManageMemberRemoveBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberSecondRemoveBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.manageMemberSecondRemoveBtn);
        }

        //Assert Manage Member Window Remove Button not displayed
        public void AssertManageMemberNoRemoveBtn()
        {
            _assertHelper.AssertElementNotDisplayed(GroupsUI.manageMemberSecondRemoveBtn);
        }

        //Press Manage Member Window Remove Button
        public void PressManageMemberRemoveBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberSecondRemoveBtn, 1);
            _driver.SafeClick(GroupsUI.manageMemberSecondRemoveBtn);
        }

        //Assert Manage Member Window Cancel Button
        public void AssertManageMemberCancelBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberSecondCancelBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.manageMemberSecondCancelBtn);
        }

        //Assert Manage Member Window Cancel Button not displayed
        public void AssertManageMemberNoCancelBtn()
        {
            _assertHelper.AssertElementNotDisplayed(GroupsUI.manageMemberSecondCancelBtn);
        }

        //Press Manage Member Window Cancel Button
        public void PressManageMemberCancelBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.manageMemberSecondCancelBtn, 1);
            _driver.SafeClick(GroupsUI.manageMemberSecondCancelBtn);
        }

        //Assert the Edit Group Window
        public void AssertEditGroupDialog()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.editGroupWindow, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.editGroupWindow);
        }

        //Assert Group Name
        public void AssertGroupName()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.name, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.name);
        }

        //Assert Group Snippet
        public void AssertGroupSnippet()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.snippet, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.snippet);
        }

        //Assert Group Description
        public void AssertGroupDescription()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.description, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.description);
        }

        //Assert Group Leader
        public void AssertGroupLeader()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupLeader, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupLeader);
        }

        //Assert Visibility
        public void AssertVisibility()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.visibilityPublic, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.visibilityPublic);
            _driver.WaitForElementAvailableAtDOM(GroupsUI.visibilityPrivate, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.visibilityPrivate);
        }

        //Press Edit Member Window Close Icon
        public void ClickEditGroupWindowCloseIcon()
        {
            _driver.SafeClick(GroupsUI.editGroupWindowCloseIcon);
        }

        //Press Edit Group Window Save Button
        public void ClickEditGroupWindowSaveBtn()
        {
            _driver.SafeClick(GroupsUI.editGroupSaveBtn);
        }

        //Press Edit Group Window Save Button
        public void ClickEditGroupWindowCancelBtn()
        {
            _driver.SafeClick(GroupsUI.editGroupCancelBtn);
        }

        //Assert the Group Name on the Groups Dashboard
        public void VerifyGroupNameDashboard(String groupName)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupNameDashboard(groupName), 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupNameDashboard(groupName));
        }

        //Assert the Group Snippet on the Groups Dashboard
        public void VerifyGroupSnippetDashboard(String groupSnippet)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupSnippetDashboard(groupSnippet), 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupSnippetDashboard(groupSnippet));
        }

        //Assert the Group Desc on the Groups Dashboard
        public void VerifyGroupDescDashboard(String groupDesc)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupDescDashboard(groupDesc), 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.groupDescDashboard(groupDesc));
        }

        //Assert Delete Group Window on click of Delete Group button from Settings Option
        public void VerifyDeleteGroupWindow()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.deleteGroupWindow, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.deleteGroupWindow);
        }

        //Assert Delete Group Window No Btn on click of Delete Group button from Settings Option
        public void VerifyDeleteGroupWindowNoBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.deleteGroupWindowNoBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.deleteGroupWindowNoBtn);
        }

        //Assert Delete Group Window Yes Btn on click of Delete Group button from Settings Option
        public void VerifyDeleteGroupWindowYesBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.deleteGroupWindowYesBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.deleteGroupWindowYesBtn);
        }

        //Press No Button from the Delete Group Window
        public void PressDeleteGroupWindowNoBtn()
        {
            _driver.SafeClick(GroupsUI.deleteGroupWindowNoBtn);
        }

        //Press Yes Button from the Delete Group Window
        public void PressDeleteGroupWindowYesBtn()
        {
            _driver.SafeClick(GroupsUI.deleteGroupWindowYesBtn);
        }

        //Press Cross Icon from the Delete Group Window
        public void PressDeleteGroupWindowCrossIcon()
        {
            _driver.SafeClick(GroupsUI.addMemberWindowCloseIcon);
        }

        //Verify the Deleted Group confirmation message
        public void VerifyDeleteGroupConfMsg()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.deleteGroupConfirmationMsg, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.deleteGroupConfirmationMsg);
        }

        //Verify the Group Error message
        public void VerifyGroupErrorMsg()
        {
            _assertHelper.AssertElementDisplayed(GroupsUI.groupErrorMessage);
        }

        //Assert Leave Group Window on click of Leave Group button from Settings Option
        public void VerifyLeaveGroupWindow()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.leaveGroupWindow, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.leaveGroupWindow);
        }

        //Assert Leave Group Window No Btn on click of Leave Group button from Settings Option
        public void VerifyLeaveGroupWindowNoBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.leaveGroupWindowNoBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.leaveGroupWindowNoBtn);
        }

        //Assert Leave Group Window Yes Btn on click of Leave Group button from Settings Option
        public void VerifyLeaveGroupWindowYesBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.leaveGroupWindowYesBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.leaveGroupWindowYesBtn);
        }

        //Press No Button from the Leave Group Window
        public void PressLeaveGroupWindowNoBtn()
        {
            _driver.SafeClick(GroupsUI.leaveGroupWindowNoBtn);
        }

        //Press Yes Button from the Leave Group Window
        public void PressLeaveGroupWindowYesBtn()
        {
            _driver.SafeClick(GroupsUI.leaveGroupWindowYesBtn);
        }

        //Press Cross Icon from the Leave Group Window
        public void PressLeaveGroupWindowCrossIcon()
        {
            _driver.SafeClick(GroupsUI.addMemberWindowCloseIcon);
        }

        //Assert Join button on the Group Page
        public void VerifyJoinBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.joinBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.joinBtn);
        }

        //Press Join button on the Group Page
        public void ClickJoinBtn()
        {
            _driver.SafeClick(GroupsUI.joinBtn);
        }

        //Assert Joined button on the Group Page
        public void VerifyJoinedBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.joinedBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.joinedBtn);
        }


        /*Discussions Tab Testing under Groups Module*/
        //Press on Group's Discussion tab
        public void ClickGroupDiscussionTab()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionTab, 1);
            _driver.SafeClick(GroupsUI.discussionTab);
        }

        //Assert the Discussions tab message div
        public void VerifyDiscussionsMsgDiv()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionMessageDiv, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.discussionMessageDiv);
        }

        //Assert the Discussions tab Type Message Div
        public void VerifyDiscussionsTypeMsgDiv()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionTypeMessageDiv, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.discussionTypeMessageDiv);
        }

        //Click the Message in the Text Area
        public void ClickMessageTextArea()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionTypeMessageArea, 1);
            _driver.SafeClick(GroupsUI.discussionTypeMessageArea);
        }

        //Enter the Message in the Text Area
        public void EnterMessageTextArea(String message)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionTypeMessageArea, 1);
            _driver.SafeEnterText(GroupsUI.discussionTypeMessageArea, message);
        }

        //Press the Message Post button
        public void ClickMessagePostBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionPostBtn, 1);
            _driver.SafeClick(GroupsUI.discussionPostBtn);
        }

        //Assert the Discussions tab Message Reply button
        public void VerifyDiscussionMsgReplyBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionReplyBtn, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.discussionReplyBtn);
        }

        //Press the Message Reply button
        public void ClickMessageReplyBtn()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionReplyBtn, 1);
            _driver.SafeClick(GroupsUI.discussionReplyBtn);
        }

        //Assert the Discussions tab Reply Type Message Div
        public void VerifyDiscussionsTypeReplyMsgDiv()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionReplyTextDiv, 1);
            _assertHelper.AssertElementDisplayed(GroupsUI.discussionReplyTextDiv);
        }

        //Click the Reply Message Text Area
        public void ClickReplyMessageTextArea()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionReplyText, 1);
            _driver.SafeClick(GroupsUI.discussionReplyText);
        }

        //Enter the Message in the Reply Text Area
        public void EnterMessageReplyTextArea(String message)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionReplyText, 1);
            _driver.SafeEnterText(GroupsUI.discussionReplyText, message);
        }

        //Press the Discussion Attachment Icon
        public void ClickDiscussionAttachIcon()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.discussionAttachIcon, 1);
            _driver.SafeClick(GroupsUI.discussionAttachIcon);
        }

        //Press on Group's Projects tab
        public void ClickGroupProjectTab()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.projectTab, 1);
            _driver.SafeClick(GroupsUI.projectTab);
        }

        //Press on Group's Events tab
        public void ClickGroupEventTab()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.eventTab, 1);
            _driver.SafeClick(GroupsUI.eventTab);
        }

        //Click the All Groups Dropdown
        public void ClickAllGroupsDropDown()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.allGroupsDrpdwnLink, 1);
            _driver.SafeClick(GroupsUI.allGroupsDrpdwnLink);
        }

        //Click the My Groups Dropdown option
        public void ClickMyGroupsDropDownOption()
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.myGroupsOption, 1);
            _driver.SafeClick(GroupsUI.myGroupsOption);
        }

        //Click Group on Groups Page
        public void ClickGroupOnGroupPage(String groupName)
        {
            _driver.WaitForElementAvailableAtDOM(GroupsUI.groupNameOnEventPage(groupName), 1);
            _driver.SafeClick(GroupsUI.groupNameOnEventPage(groupName));
        }



    }
}
