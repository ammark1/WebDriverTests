using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyTeam.UILocators
{
    public static class PostProjectUI
    {
        public readonly static By postAProjectTab = By.XPath("//div[contains(@class, 'pull-left')]//a[text()= 'POST A PROJECT']");
        public readonly static By projectName = By.XPath("//input[@name='abstract']");
        public readonly static By projectDesc = By.XPath("//textarea[@name='description']");
        public readonly static By projectLocation = By.XPath("//input[@name='location']");
        public readonly static By startDate = By.XPath("//input[@title='start date']");
        public readonly static By dueDate = By.XPath("//input[@title='due date']");
        public readonly static By membersNeeded = By.XPath("//input[@name='numberOfMembers']");
        public readonly static By skillsNeeded = By.XPath("//input[@placeholder='+ Add skills']");
        public readonly static By specificallyAddMember = By.XPath("//input[@placeholder='Type a name or email']");
        public readonly static By specificallyAddMemberPlusIcon = By.XPath("//div[@class= 'rt-add-button']");
        public readonly static By createBtn = By.XPath("//a[text()= 'Create Project']");
        public readonly static By aboutTab = By.XPath("//a[text()= 'About']");
        public readonly static By updateMetricsBtn = By.XPath("//a[text()= 'Update Metrics']");
        public readonly static By addedMemberRemoveIcon = By.XPath("//div[contains(@class, 'rt-projects-members')]//i[contains(@class, 'rt-member__remove-btn')]");

        public readonly static By addMemberIcon = By.XPath("//li[1]/a/div/i");
        public readonly static By deleteProjectIcon = By.XPath("//li[2]/a/div/i");

        public static By suggestedMemberName(string variable)
        {
            return By.XPath("//a[contains(text(), '" + variable + "')]");
        }
        public readonly static By addMemberWindow = By.XPath("//div[@class= 'modal-dialog']//div[contains(text(), 'Add Members')]");
        public readonly static By addWindowAddButton = By.XPath("//div[@class= 'modal-dialog']//a[contains(text(), 'Add')]");
        public readonly static By addMemberText = By.XPath("//form[@name= 'addUsersForm']//input[contains(@class, 'input')]");
        public static By addMemberSuggList(string variable)
        {
            return By.XPath("//ul[contains(@class, 'suggestion-list')]//span[contains(text(), '" + variable + "')]");
        }
        public static By addMemberConfirmationMsg(string variable)
        {
            return By.XPath("//div[contains(@class, 'cg-notify-message')]//div[contains(text(), '" + variable + "')]");
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
            return By.XPath("//div[contains(@class, 'chat-activity-list')]//div[2]//p[contains(text(), '" + variable + "')]");
        }
        public readonly static By discussionReplyBtn = By.XPath("//div[contains(@class, 'chat-activity-list')]//div[2]//a[contains(text(), 'Reply')]");
        public readonly static By discussionReplyTextDiv = By.XPath("//div[contains(@class, 'chat-activity-list']//div[2]//div[contains(@class, 'media-body-replies')]");
        public readonly static By discussionReplyText = By.XPath("//form[contains(@class, 'ng-dirty')]//div[contains(@id, 'taTextElement')]");
        public readonly static By discussionReplyPostBtn = By.XPath("//div[2]/div/rt-activity-feed-post/div/form/div/div[2]/button");

        public readonly static By projectTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'Projects')]");
        public readonly static By eventTab = By.XPath("//ul[contains(@class, 'nav nav-tabs')]//a[contains(text(), 'Events')]");

        public readonly static By privateProjectCheckbox = By.XPath("//span[contains(@class, 'rt-checkbox')]");
        public readonly static By privateProjectIcon = By.XPath("//a[contains(text(), 'Private')]");
        public readonly static By publicProjectIcon = By.XPath("//a[contains(text(), 'Public')]");
        public readonly static By noProjectDisplayedMsg = By.XPath("//span[text()= 'No projects match the search criteria. Please try refining your search.']");

    }
}
