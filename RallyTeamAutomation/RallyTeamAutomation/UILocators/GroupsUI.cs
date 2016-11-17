using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyTeam.UILocators
{
    public static class GroupsUI
    {
        public readonly static By addNewGroupBtn = By.LinkText("New Group");
        public static By groupNameDashboard(string variable)
        {
            return By.XPath("//div[contains(text(), '" + variable + "')]");
        }
        public static By groupSnippetDashboard(string variable)
        {
            return By.XPath("//div[contains(text(), '"+variable+"')]");
        }
        public static By groupDescDashboard(string variable)
        {
            return By.XPath("//div[contains(@class, 'm-t-md')]//div[contains(text(), '" + variable+")')]");
        }

        public readonly static By allGroupsDrpdwnLink = By.XPath("//a[@class='dropdown-toggle']//*[contains(text(), 'All Groups')]");
        public static By allGroupsOption = By.XPath("//ul[@class='dropdown-menu']/li[1]");
        public static By myGroupsOption = By.XPath("//ul[@class='dropdown-menu']/li[2]");
        public static By groupNameOnEventPage(String variable)
        {
            return By.XPath("//a[contains(text(), '" + variable + "')]");
        }

        public readonly static By aboutTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'About')]");

        public readonly static By joinBtn = By.XPath("//button[contains(text(), 'Join')]");
        public readonly static By joinedBtn = By.XPath("//button[contains(text(), 'Joined')]");
        public readonly static By addGroupsDlg = By.XPath("//*[contains(@class, 'ibox-content')]//span[contains(text(), 'Create a Group')]");
        public readonly static By groupUploadPhoto = By.XPath("//*[contains(@class, 'rt-event-photo')]//label[contains(text(), 'Upload Photo')]");
        public readonly static By groupUploadPhotoSaveBtn = By.XPath("//*[contains(@class, 'modal-content')]//a[contains(text(), 'Save')]");
        public readonly static By groupChangePhoto = By.Id("image-select");
        public readonly static By groupPhotoArea = By.XPath("//*[contains(@class, 'rt-event-photo')]//img");
        public readonly static By name = By.XPath("//*[contains(@class, 'form-group')]//input[@name='abstract']");
        public readonly static By snippet = By.XPath("//*[contains(@class, 'form-group')]//input[@name='snippet']");
        public readonly static By description = By.XPath("//textarea[@name='description']");
        public readonly static By groupLeader = By.XPath("//*[contains(@class, 'form-group')]//select[@name='moderator']");
        public readonly static By selectedGrpLeader = By.XPath("//select[(@name='moderator')]//option[1]");
        public static By droDownMenu(string variable)
        {
            return By.XPath("//select[(@name='moderator')]//option[contains(text(), '"+variable+"')]");
        }
        public readonly static By visibilityPublic = By.XPath("//*[contains(@class, 'form-group')]//input[@id='inlineRadio1']");
        public readonly static By visibilityPrivate = By.XPath("//*[contains(@class, 'form-group')]//input[@id='inlineRadio2']");
        public readonly static By createBtn = By.XPath("//*[contains(@class, 'form-actions')]//button[contains(text(), 'Create')]");
        public readonly static By cancelBtn = By.XPath("//*[contains(@class, 'form-actions')]//a[contains(text(), 'Cancel')]");
        public readonly static By settings = By.XPath("//button[contains(@class, 'rt-settings-btn')]");
        public static By settingsOptions(string variable)
        {
            return By.XPath("//li[@class='ng-scope']//a[contains(text(), '"+variable+"')]");
        }
        public readonly static By addMemberIcon = By.XPath("//i[@class='fa fa-user-plus']");
        public readonly static By addMemberWindow = By.XPath("//div[@class= 'modal-dialog']//div[contains(text(), 'Add Members')]");
        public readonly static By addWindowAddButton = By.XPath("//div[@class= 'modal-dialog']//a[contains(text(), 'Add')]");
        public readonly static By addMemberText = By.XPath("//form[@name= 'addUsersForm']//input[contains(@class, 'input')]");
        public static By addMemberSuggList(string variable)
        {
            return By.XPath("//ul[contains(@class, 'suggestion-list')]//span[contains(text(), '"+variable+"')]");
        }
        public static By addMemberConfirmationMsg(string variable)
        {
            return By.XPath("//div[contains(@class, 'cg-notify-message')]//div[contains(text(), '"+variable+"')]");
        }
        public readonly static By addMemberWindowCloseIcon = By.XPath("//div[contains(@class, 'modal-dialog')]//i[contains(@class, 'fa fa-times')]");
        public readonly static By manageMemberWindow = By.XPath("//div[contains(@class, 'modal-dialog')]//a[contains(text(), 'All Members')]");
        public readonly static By manageMemberSecondCrossIcon = By.XPath("//div[contains(@class, 'rt-modal__tab--scroll')]//div[2]//i[contains(@class, 'fa fa-times')]");
        public readonly static By manageMemberSecondRemoveBtn = By.XPath("//html/body/div[11]/div/div/div/div/div/div/div[2]/div[2]/button[1]");       
        public readonly static By manageMemberSecondCancelBtn = By.XPath("//html/body/div[11]/div/div/div/div/div/div/div[2]/div[2]/button[2]");



        public readonly static By editGroupWindow = By.XPath("//div[contains(@class, 'ng-scope')]//span[contains(text(), 'Edit this Group')]");
        public readonly static By editGroupWindowCloseIcon = By.XPath("//i[contains(@class, 'fa fa-times')]");

        public readonly static By editGroupSaveBtn = By.XPath("//button[@value='Save']");
        public readonly static By editGroupCancelBtn = By.XPath("//a[contains(text(),'Cancel')]");

        public readonly static By deleteGroupWindow = By.XPath("//div[contains(@class, 'modal-dialog')]//h3[contains(text(),'Are you sure you want to delete this group?')]");
        public readonly static By deleteGroupWindowNoBtn = By.XPath("//div[contains(@class, 'modal-dialog')]//a[contains(text(),'No')]");
        public readonly static By deleteGroupWindowYesBtn = By.XPath("//div[contains(@class, 'modal-dialog')]//a[contains(text(),'Yes')]");
        public static By deleteGroupConfirmationMsg = By.XPath("//div[contains(@class, 'cg-notify-message')]//div[contains(text(), 'Group has been deleted.')]");

        public static By groupErrorMessage = By.XPath("//form[contains(@class, 'ng-invalid ng-invalid-required')]//span[contains(text(), 'Please correct the errors in the form to continue.')]");

        public readonly static By leaveGroupWindow = By.XPath("//div[contains(@class, 'modal-dialog')]//h3[contains(text(),'Are you sure you want to delete this group?')]");
        public readonly static By leaveGroupWindowNoBtn = By.XPath("//div[contains(@class, 'modal-dialog')]//a[contains(text(),'No')]");
        public readonly static By leaveGroupWindowYesBtn = By.XPath("//div[contains(@class, 'modal-dialog')]//a[contains(text(),'Yes')]");

        public readonly static By discussionTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'Discussions')]");
        public readonly static By discussionMessageDiv = By.XPath("//div[contains(@class, 'message-main')]");
        public readonly static By discussionTypeMessageDiv = By.XPath("//div[contains(@class, 'ta-scroll-window')]");
        public readonly static By discussionTypeMessageArea = By.XPath("//div[contains(@id, 'taTextElement')]");
        public readonly static By discussionAttachIcon = By.XPath("//i[contains(@class, 'fa fa-paperclip')]");
        public readonly static By discussionPostBtn = By.XPath("//div[contains(@class, 'text-right')]//button[contains(@class, 'btn')]");
        public static By discussionMsgPosted(String variable)
        {
            return By.XPath("//div[contains(@class, 'chat-activity-list')]//div[2]//p[contains(text(), '"+variable+"')]");
        }
        public readonly static By discussionReplyBtn = By.XPath("//div[contains(@class, 'chat-activity-list')]//div[2]//a[contains(text(), 'Reply')]");
        public readonly static By discussionReplyTextDiv = By.XPath("//div[contains(@class, 'chat-activity-list']//div[2]//div[contains(@class, 'media-body-replies')]");
        public readonly static By discussionReplyText = By.XPath("//form[contains(@class, 'ng-dirty')]//div[contains(@id, 'taTextElement')]");
        public readonly static By discussionReplyPostBtn = By.XPath("//div[2]/div/rt-activity-feed-post/div/form/div/div[2]/button");

        public readonly static By projectTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'Projects')]");
        public readonly static By eventTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'Events')]");


    }
}
