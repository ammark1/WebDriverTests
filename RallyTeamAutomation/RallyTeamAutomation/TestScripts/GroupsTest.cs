
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
using RallyTeam;
using log4net;
using System.Reflection;

namespace RallyTeam.TestScripts
{
    [TestFixture]
    [Category("Groups")]
    public class GroupsTest : BaseTest
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static ReadData readGroups = new ReadData("Groups");

        //SignIn
        private void SignInDifferentUser()
        {
            String userName = readGroups.GetValue("SignInDifferentUser", "userName");
            String password = readGroups.GetValue("SignInDifferentUser", "password");
            authenticationPage.SetUserName(userName);
            authenticationPage.SetPassword(password);
            authenticationPage.ClickOnLoginButton();
        }

        //Delete Group
        public void DeleteGroup()
        {
            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            Log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Delete Group'
            groupsPage.ClickSettingsOptionsValues("Delete Group");
            Log.Info("Verified Settings option value: 'Delete Group'");
            Thread.Sleep(2000);

            //Click the Delete Group Window Yes Button
            groupsPage.PressDeleteGroupWindowYesBtn();
            Log.Info("Click the Delete Group Member Window Yes Button.");
            Thread.Sleep(2000);
        }

        //Create a Group
        public void CreateGroup(String groupName)
        {
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Enter the Group Name
            Thread.Sleep(2000);
            groupsPage.enterNewGroupName(groupName);

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Enter the Group Description
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupDesc = readGroups.GetValue("AddGroupDetails", "groupDesc");
            groupsPage.enterNewGroupDescription(groupDesc);

            //Select a Group Leader
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();
        }

        [Test]
        public void Groups_001_VerifyGroupsOption()
        {
            Global.MethodName = "Groups_001_VerifyGroupsOption";
            groupsPage.VerifyGroupMenuOption();
            Log.Info("Verify group menu icon");
        }

        [Test]
        public void Groups_005_VerifyGroupLeaderDropDown()
        {
            Global.MethodName = "Groups_005_VerifyGroupLeaderDropDown";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Verify the add new group form window
            Thread.Sleep(5000);
            groupsPage.assertAddGroupDialog();
            log.Info("Verify the add new group form window");

            //Verify the Selected Group Leader 
            Thread.Sleep(5000);
            String expectedGroupLeader = readGroups.GetValue("GroupLeader", "expectedGroupLeader");
            groupsPage.GetGroupLeaderSelectedOption(expectedGroupLeader);

            //Change the Group Leader
            String changeDefaultGroupLeader = readGroups.GetValue("GroupLeader", "changeDefaultGroupLeader");
            groupsPage.selectOptionFromGroupLeader(changeDefaultGroupLeader);
        }


        [Test]
        public void Groups_008_TestCreatePublicGroup()
        {
            Global.MethodName = "Groups_008_TestCreatePublicGroup";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Verify the add new group form window
            Thread.Sleep(5000);
            groupsPage.assertAddGroupDialog();
            log.Info("Verify the add new group form window");

            //Enter the Group Name
            Thread.Sleep(2000);
            String groupName = readGroups.GetValue("AddPublicGroupDetails", "groupName");
            groupsPage.enterNewGroupName(groupName);

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddPublicGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Enter the Group Description
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupDesc = readGroups.GetValue("AddPublicGroupDetails", "groupDesc");
            groupsPage.enterNewGroupDescription(groupDesc);

            //Select a Group Leader
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddPublicGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddPublicGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_009_TestCreatePrivateGroup()
        {
            Global.MethodName = "Groups_009_TestCreatePrivateGroup";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Verify the add new group form window
            Thread.Sleep(5000);
            groupsPage.assertAddGroupDialog();
            log.Info("Verify the add new group form window");

            //Enter the Group Name
            Thread.Sleep(2000);
            String groupName = readGroups.GetValue("AddPrivateGroupDetails", "groupName");
            groupsPage.enterNewGroupName(groupName);

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddPrivateGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Enter the Group Description
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupDesc = readGroups.GetValue("AddPrivateGroupDetails", "groupDesc");
            groupsPage.enterNewGroupDescription(groupDesc);

            //Select a Group Leader
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddPrivateGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddPrivateGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_011_SettingsOptionGrpLeader()
        {
            Global.MethodName = "Groups_011_SettingsOptionGrpLeader";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(5000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Verify Settings Options value 'Add Member'
            groupsPage.GetSettingsOptionsValues("Add Members");
            log.Info("Verified Settings option value: 'Add Members'");
            Thread.Sleep(2000);

            //Verify Settings Options value 'Manage Members'
            groupsPage.GetSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Member'");
            Thread.Sleep(2000);

            //Verify Settings Options value 'Edit Group'
            groupsPage.GetSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Settings Options value 'Delete Group'
            groupsPage.GetSettingsOptionsValues("Delete Group");
            log.Info("Verified Settings option value: 'Delete Group'");
            Thread.Sleep(2000);

            //Click Settings option
            Thread.Sleep(5000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_012_ClickAddMemberAndVerify()
        {
            Global.MethodName = "Groups_012_ClickAddMemberAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Verify Add Member Window
            groupsPage.AssertAddGroupMemberDialog();
            log.Info("Verify the Add Group Member Window.");
            Thread.Sleep(2000);

            //Verify the Add button
            groupsPage.AssertAddWindowAddButton();
            log.Info("Verify the Add Window Add button.");
            Thread.Sleep(2000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_013_AddMemberInGroup()
        {
            Global.MethodName = "Groups_013_AddMemberInGroup";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Enter the Group Member Email
            String addMemberEmail = readGroups.GetValue("AddGroupMember", "addMemberEmail");
            groupsPage.EnterGroupMemberEmail(addMemberEmail);
            log.Info("Entered " + addMemberEmail + " into Add Member Text field ");
            Thread.Sleep(5000);

            //Select user from suggestion
            String addMemberName = readGroups.GetValue("AddGroupMember", "addMemberName");
            groupsPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");
            Thread.Sleep(5000);

            //Click the Add button
            groupsPage.ClickAddWindowAddButton();
            log.Info("Click on Add Window Add button.");
            Thread.Sleep(2000);

            //Verify the added member confirmation message
            String messageText = "(" + addMemberEmail + ") has been added.";
            groupsPage.VerifyAddedMemberConfMsg(messageText);
            log.Info("Verified group member added confirmation message.");
            Thread.Sleep(5000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_014_AddMultipleMembersInGroup()
        {
            Global.MethodName = "Groups_014_AddMultipleMembersInGroup";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Enter the Group Member Email and select users from suggestion
            String addMembersEmail = readGroups.GetValue("AddMultipleGroupMembers", "addMembersEmail");
            List<String> addMembersEmailList = addMembersEmail.Split(',').ToList();
            int noOfMember = addMembersEmailList.Count;
            foreach (String value in addMembersEmailList)
            {
                groupsPage.EnterGroupMemberEmail(value);
                Thread.Sleep(2000);
                groupsPage.PressEnterKey();
                Thread.Sleep(5000);
            }

            //Click the Add button
            groupsPage.ClickAddWindowAddButton();
            log.Info("Click on Add Window Add button.");
            Thread.Sleep(2000);

            //Verify the added member confirmation message
            String messageText = noOfMember + " Members have been added.";
            groupsPage.VerifyAddedMemberConfMsg(messageText);
            log.Info("Verified group member added confirmation message.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_015_ClickAddMemberAndClose()
        {
            Global.MethodName = "Groups_015_ClickAddMemberAndClose";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Verify Add Member Window
            groupsPage.AssertAddGroupMemberDialog();
            log.Info("Verify the Add Group Member Window.");
            Thread.Sleep(2000);

            //Enter the Group Member Email
            String addMemberEmail = readGroups.GetValue("DoNotAddMember", "addMemberEmail");
            groupsPage.EnterGroupMemberEmail(addMemberEmail);
            log.Info("Entered " + addMemberEmail + " into Add Member Text field ");
            Thread.Sleep(5000);

            //Select user from suggestion
            String addMemberName = readGroups.GetValue("DoNotAddMember", "addMemberName");
            groupsPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");
            Thread.Sleep(2000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_016_ClickManageMembersAndVerify()
        {
            Global.MethodName = "Groups_016_ClickManageMembersAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Manage Members'
            groupsPage.ClickSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Members'");
            Thread.Sleep(2000);

            //Verify Manage Member Window
            groupsPage.AssertManageGroupMemberDialog();
            log.Info("Verify the Manage Group Member Window.");
            Thread.Sleep(2000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_017_VerifyManageMembersRemoveCancel()
        {
            Global.MethodName = "Groups_017_VerifyManageMembersRemoveCancel";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Enter the Group Member Email
            String addMemberEmail = readGroups.GetValue("AddGroupMember", "addMemberEmail");
            groupsPage.EnterGroupMemberEmail(addMemberEmail);
            log.Info("Entered " + addMemberEmail + " into Add Member Text field ");
            Thread.Sleep(5000);

            //Select user from suggestion
            String addMemberName = readGroups.GetValue("AddGroupMember", "addMemberName");
            groupsPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");
            Thread.Sleep(5000);

            //Click the Add button
            groupsPage.ClickAddWindowAddButton();
            log.Info("Click on Add Window Add button.");
            Thread.Sleep(3000);

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Manage Members'
            groupsPage.ClickSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Members'");
            Thread.Sleep(5000);

            //Click cross icon of second record
            groupsPage.ClickManageMemberSecondCrossIcon();
            log.Info("Click on Cross icon of the second member");
            Thread.Sleep(2000);

            //Verify Manage Member Window Remove Button
            groupsPage.AssertManageMemberRemoveBtn();
            log.Info("Verify the Manage Group Member Remove Button.");
            Thread.Sleep(2000);

            //Verify Manage Member Window Cancel Button
            groupsPage.AssertManageMemberCancelBtn();
            log.Info("Verify the Manage Group Member Cancel Button.");
            Thread.Sleep(2000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_019_ClickManageMembersCancelBtn()
        {
            Global.MethodName = "Groups_019_ClickManageMembersCancelBtn";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Enter the Group Member Email
            String addMemberEmail = readGroups.GetValue("AddGroupMember", "addMemberEmail");
            groupsPage.EnterGroupMemberEmail(addMemberEmail);
            log.Info("Entered " + addMemberEmail + " into Add Member Text field ");
            Thread.Sleep(5000);

            //Select user from suggestion
            String addMemberName = readGroups.GetValue("AddGroupMember", "addMemberName");
            groupsPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");
            Thread.Sleep(5000);

            //Click the Add button
            groupsPage.ClickAddWindowAddButton();
            log.Info("Click on Add Window Add button.");
            Thread.Sleep(3000);

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Manage Members'
            groupsPage.ClickSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Members'");
            Thread.Sleep(5000);

            //Click cross icon of second record
            groupsPage.ClickManageMemberSecondCrossIcon();
            log.Info("Click on Cross icon of the second member");
            Thread.Sleep(2000);

            //Click Manage Member Window Cancel Button
            groupsPage.PressManageMemberCancelBtn();
            log.Info("Click Manage Group Member Cancel Button.");
            Thread.Sleep(2000);

            //Verify Manage Member Window Remove Button
            groupsPage.AssertManageMemberNoRemoveBtn();
            log.Info("Verify the Manage Group Member Remove Button.");
            Thread.Sleep(2000);

            //Verify Manage Member Window Cancel Button
            groupsPage.AssertManageMemberNoCancelBtn();
            log.Info("Verify the Manage Group Member Cancel Button.");
            Thread.Sleep(5000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_018_ClickManageMembersRemoveBtn()
        {
            Global.MethodName = "Groups_018_ClickManageMembersRemoveBtn";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Add Group Member Icon
            groupsPage.ClickOnAddMemberIcon();
            log.Info("Click on the Add Member Icon after Group is created.");
            Thread.Sleep(5000);

            //Enter the Group Member Email
            String addMemberEmail = readGroups.GetValue("AddGroupMember", "addMemberEmail");
            groupsPage.EnterGroupMemberEmail(addMemberEmail);
            log.Info("Entered " + addMemberEmail + " into Add Member Text field ");
            Thread.Sleep(5000);

            //Select user from suggestion
            String addMemberName = readGroups.GetValue("AddGroupMember", "addMemberName");
            groupsPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");
            Thread.Sleep(5000);

            //Click the Add button
            groupsPage.ClickAddWindowAddButton();
            log.Info("Click on Add Window Add button.");
            Thread.Sleep(3000);

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Manage Members'
            groupsPage.ClickSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Members'");
            Thread.Sleep(5000);

            //Click cross icon of second record
            groupsPage.ClickManageMemberSecondCrossIcon();
            log.Info("Click on Cross icon of the second member");
            Thread.Sleep(2000);

            //Click Manage Member Window Remove Button
            groupsPage.PressManageMemberRemoveBtn();
            log.Info("Click Manage Group Member Remove Button.");
            Thread.Sleep(2000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_020_ClickManageMembersCloseIcon()
        {
            Global.MethodName = "Groups_020_ClickManageMembersCloseIcon";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Manage Members'
            groupsPage.ClickSettingsOptionsValues("Manage Members");
            log.Info("Verified Settings option value: 'Manage Members'");
            Thread.Sleep(5000);

            //Click Add Member Window Close Icon
            groupsPage.ClickAddWindMemberWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_022_ClickEditGroupAndVerify()
        {
            Global.MethodName = "Groups_022_ClickEditGroupAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Verify Group Name displayed
            groupsPage.AssertGroupName();
            log.Info("Verify the Group Name field.");
            Thread.Sleep(2000);

            //Verify Group Snippet displayed
            groupsPage.AssertGroupSnippet();
            log.Info("Verify the Group Snippet field.");
            Thread.Sleep(2000);

            //Verify Group Description displayed
            groupsPage.AssertGroupDescription();
            log.Info("Verify the Group Description field.");
            Thread.Sleep(2000);

            //Verify Group Leader displayed
            groupsPage.AssertGroupLeader();
            log.Info("Verify the Group Leader field.");
            Thread.Sleep(2000);

            //Verify Group Visibility displayed
            groupsPage.AssertVisibility();
            log.Info("Verify the Group Visibility field.");
            Thread.Sleep(2000);

            //Click Edit Group Window Close Icon
            groupsPage.ClickEditGroupWindowCloseIcon();
            log.Info("Close icon clicked successfully.");
            Thread.Sleep(3000);

            //Delete the group
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_024_EditGroupName()
        {
            Global.MethodName = "Groups_024_EditGroupName";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Name
            String editGroupName = readGroups.GetValue("EditGroup", "editGroupName");
            groupsPage.enterNewGroupName(editGroupName);
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Verify the Edited Group Name on the group dashboard
            groupsPage.VerifyGroupNameDashboard(editGroupName);
            log.Info("Verified edited group Name");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_025_EditGroupSnippet()
        {
            Global.MethodName = "Groups_025_EditGroupSnippet";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Snippet
            String editGroupSnippet = readGroups.GetValue("EditGroup", "editGroupSnippet");
            groupsPage.enterNewGroupSnippet(editGroupSnippet);
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Verify the Edited Group Snippet on the group dashboard
            groupsPage.VerifyGroupSnippetDashboard(editGroupSnippet);
            log.Info("Verified edited group Snippet");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_026_EditGroupDescription()
        {
            Global.MethodName = "Groups_026_EditGroupDescription";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Description
            String editGroupDesc = readGroups.GetValue("EditGroup", "editGroupDesc");
            groupsPage.enterNewGroupDescription(editGroupDesc);
            Thread.Sleep(2000);
            commonPage.ScrollUp();
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(6000);
            /*
            //Verify the Edited Group Desc on the group dashboard
            commonPage.ScrollDown();
            Thread.Sleep(3000);
            groupsPage.VerifyGroupDescDashboard(editGroupDesc);
            log.Info("Verified edited group Desc");
            Thread.Sleep(3000);*/

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }
    
        [Test]
        public void Groups_029_CancelEditGroupDescription()
        {
            Global.MethodName = "Groups_029_CancelEditGroupDescription";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Visibility
            String editGroupVisibility = readGroups.GetValue("EditGroup", "editGroupVisibility");
            groupsPage.selectVisibility(editGroupVisibility);
            Thread.Sleep(2000);
            commonPage.ScrollUp();
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(6000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_028_EditGroupVisibility()
        {
            Global.MethodName = "Groups_028_EditGroupVisibility";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Click Edit Group Window Cancel Button
            groupsPage.ClickEditGroupWindowCancelBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(6000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_027_EditGroupLeader()
        {
            Global.MethodName = "Groups_027_EditGroupLeader";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Leader
            String editgroupLeader = readGroups.GetValue("EditGroup", "editgroupLeader");
            groupsPage.selectOptionFromGroupLeader(editgroupLeader);
            Thread.Sleep(2000);
            commonPage.ScrollUp();
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Click Settings option
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);

            //Verify Settings Options value 'Leave Group'
            groupsPage.GetSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_030_ClickDeleteGroupAndVerify()
        {
            Global.MethodName = "Groups_030_ClickDeleteGroupAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Delete Group'
            groupsPage.ClickSettingsOptionsValues("Delete Group");
            log.Info("Verified Settings option value: 'Delete Group'");
            Thread.Sleep(2000);

            //Verify Delete Group Window
            groupsPage.VerifyDeleteGroupWindow();
            log.Info("Verify the Delete Group Member Window.");
            Thread.Sleep(2000);

            //Verify Delete Group Window No Button 
            groupsPage.VerifyDeleteGroupWindowNoBtn();
            log.Info("Verify the Delete Group Member Window No Button.");
            Thread.Sleep(2000);

            //Verify Delete Group Window Yes Button 
            groupsPage.VerifyDeleteGroupWindowYesBtn();
            log.Info("Verify the Delete Group Member Window.");
            Thread.Sleep(2000);

            //Close the Delete Group Window Close icon
            groupsPage.PressDeleteGroupWindowCrossIcon();
            log.Info("Close the Delete Group Member Window.");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_031_ClickDeleteGroupWindowNoBtn()
        {
            Global.MethodName = "Groups_031_ClickDeleteGroupWindowNoBtn";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Delete Group'
            groupsPage.ClickSettingsOptionsValues("Delete Group");
            log.Info("Verified Settings option value: 'Delete Group'");
            Thread.Sleep(2000);

            //Click the Delete Group Window No Button
            groupsPage.PressDeleteGroupWindowNoBtn();
            log.Info("Click the Delete Group Member Window No Button.");
            Thread.Sleep(2000);

            //Verify Group is not deleted
            groupsPage.VerifyGroupNameDashboard(groupName);
            log.Info("Verified the group Name");
            Thread.Sleep(3000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_032_ClickDeleteGroupWindowYesBtn()
        {
            Global.MethodName = "Groups_032_ClickDeleteGroupWindowYesBtn";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Delete Group'
            groupsPage.ClickSettingsOptionsValues("Delete Group");
            log.Info("Verified Settings option value: 'Delete Group'");
            Thread.Sleep(2000);

            //Click the Delete Group Window Yes Button
            groupsPage.PressDeleteGroupWindowYesBtn();
            log.Info("Click the Delete Group Member Window Yes Button.");
            Thread.Sleep(2000);

            //Verify Group deleted confirmation message
            groupsPage.VerifyDeleteGroupConfMsg();
            log.Info("Verify the deleted group confirmation message.");
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_035_CreateGroupWithoutName()
        {
            Global.MethodName = "Groups_035_CreateGroupWithoutName";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Verify the add new group form window
            Thread.Sleep(5000);
            groupsPage.assertAddGroupDialog();
            log.Info("Verify the add new group form window");

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddPublicGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Enter the Group Description
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupDesc = readGroups.GetValue("AddPublicGroupDetails", "groupDesc");
            groupsPage.enterNewGroupDescription(groupDesc);

            //Select a Group Leader
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddPublicGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddPublicGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();

            //Verify the error message for not entering the Group Name
            Thread.Sleep(2000);
            groupsPage.VerifyGroupErrorMsg();
            log.Info("Verify the error message for not entering Group Name.");

            //Click Cancel button
            Thread.Sleep(2000);
            groupsPage.ClickOnCancelButton();
            log.Info("Click on Cancel button.");
        }

        /*[Test]
        public void Groups_036_CreateDuplicateGroup()
        {
            Global.MethodName = "Groups_036_CreateDuplicateGroup";

            //Create a group 
            Thread.Sleep(5000);
            String groupNameOriginal = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            CreateGroup(groupNameOriginal);
            log.Info("Create a group with Original Name");

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Enter the Duplicate Group Name
            Thread.Sleep(2000);
            String groupNameDuplicate = readGroups.GetValue("AddGroupDetails", "groupNameDuplicate");
            groupsPage.enterNewGroupName(groupNameDuplicate);

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Enter the Group Description
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupDesc = readGroups.GetValue("AddGroupDetails", "groupDesc");
            groupsPage.enterNewGroupDescription(groupDesc);

            //Select a Group Leader
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();

            //Verify the error message for entering duplicate Group Name
            Thread.Sleep(2000);
            groupsPage.VerifyGroupErrorMsg();
            log.Info("Verify the error message for not entering Group Name.");

            //Click Cancel button
            Thread.Sleep(2000);
            groupsPage.ClickOnCancelButton();
            log.Info("Click on Cancel button.");
        }*/

        [Test]
        public void Groups_038_CreateGroupWithoutDesc()
        {
            Global.MethodName = "Groups_038_CreateGroupWithoutDesc";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'");

            //Click on Add New Group button
            Thread.Sleep(5000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page");

            //Verify the add new group form window
            Thread.Sleep(5000);
            groupsPage.assertAddGroupDialog();
            log.Info("Verify the add new group form window");

            //Enter the Group Name
            Thread.Sleep(2000);
            String groupNameWithoutDesc = readGroups.GetValue("AddGroupDetails", "groupNameWithoutDesc");
            groupsPage.enterNewGroupName(groupNameWithoutDesc);

            //Enter the Group Snippet
            Thread.Sleep(2000);
            String groupSnippet = readGroups.GetValue("AddGroupDetails", "groupSnippet");
            groupsPage.enterNewGroupSnippet(groupSnippet);

            //Select a Group Leader
            Thread.Sleep(2000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            String groupLeader = readGroups.GetValue("AddGroupDetails", "groupLeader");
            groupsPage.selectOptionFromGroupLeader(groupLeader);

            //Select Group Visibility
            Thread.Sleep(2000);
            String groupVisibility = readGroups.GetValue("AddGroupDetails", "groupVisibility");
            groupsPage.selectVisibility(groupVisibility);

            //Click on the create button at Add New Group form
            Thread.Sleep(2000);
            groupsPage.clickOnCreateButton();

            //Verify the error message for not entering the Group Description
            Thread.Sleep(2000);
            groupsPage.VerifyGroupErrorMsg();
            log.Info("Verify the error message for not entering Group Description.");

            //Click Cancel button
            Thread.Sleep(2000);
            groupsPage.ClickOnCancelButton();
            log.Info("Click on Cancel button.");
        }

        [Test]
        public void Groups_039_VerifyJoinBtn()
        {
            Global.MethodName = "Groups_039_VerifyJoinBtn";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Now change the group leader
            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Leader
            String editgroupLeader = readGroups.GetValue("EditGroup", "editgroupLeader");
            groupsPage.selectOptionFromGroupLeader(editgroupLeader);
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Now leave the group
            //Click Settings option
            commonPage.ScrollUp();
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);

            //Click Settings Options value 'Leave Group'
            groupsPage.ClickSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);

            //Click Yes on confirmation message
            groupsPage.PressLeaveGroupWindowYesBtn();
            log.Info("Click on Yes button from Leave Group window.");
            Thread.Sleep(2000);

            //Verify Join button present on the screen or not
            Thread.Sleep(2000);
            groupsPage.VerifyJoinBtn();
            log.Info("Verify the join button on the screen");
        }

        [Test]
        public void Groups_040_ClickJoinAndVerify()
        {
            Global.MethodName = "Groups_040_ClickJoinAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Now change the group leader
            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Page Down
            commonPage.ScrollDown();
            Thread.Sleep(2000);

            //Edit Group Leader
            String editgroupLeader = readGroups.GetValue("EditGroup", "editgroupLeader");
            groupsPage.selectOptionFromGroupLeader(editgroupLeader);
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Now leave the group
            //Click Settings option
            commonPage.ScrollUp();
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);
            //Click Settings Options value 'Leave Group'
            groupsPage.ClickSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);

            //Click Yes on confirmation message
            groupsPage.PressLeaveGroupWindowYesBtn();
            log.Info("Click on Yes button from Leave Group window.");
            Thread.Sleep(2000);

            //Click on Join button to join the Group
            groupsPage.ClickJoinBtn();
            log.Info("Click on Join button to join the Group");
            Thread.Sleep(2000);

            //Verify Joined button present on the screen or not
            Thread.Sleep(2000);
            groupsPage.VerifyJoinedBtn();
            log.Info("Verify the joined button on the screen");

            //Click Settings option
            commonPage.ScrollUp();
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);

            //Verify Settings Options value 'Leave Group'
            groupsPage.GetSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_041_LeaveGroupAndVerify()
        {
            Global.MethodName = "Groups_041_LeaveGroupAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Now change the group leader
            //Click Settings option
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickSettingsOption();
            log.Info("Click on the Settings option after Group is created.");

            //Click Settings Options value 'Edit Group'
            groupsPage.ClickSettingsOptionsValues("Edit Group");
            log.Info("Verified Settings option value: 'Edit Group'");
            Thread.Sleep(2000);

            //Verify Edit Group Window
            groupsPage.AssertEditGroupDialog();
            log.Info("Verify the Edit Group Member Window.");
            Thread.Sleep(2000);

            //Edit Group Leader
            String editgroupLeader = readGroups.GetValue("EditGroup", "editgroupLeader");
            groupsPage.selectOptionFromGroupLeader(editgroupLeader);
            Thread.Sleep(2000);

            //Click Edit Group Window Save Button
            groupsPage.ClickEditGroupWindowSaveBtn();
            log.Info("Save clicked successfully.");
            Thread.Sleep(5000);

            //Now leave the group
            //Click Settings option
            commonPage.ScrollUp();
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);
            //Click Settings Options value 'Leave Group'
            groupsPage.ClickSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);

            //Click Yes on confirmation message
            groupsPage.PressLeaveGroupWindowYesBtn();
            log.Info("Click on Yes button from Leave Group window.");
            Thread.Sleep(2000);

            //Click on Join button to join the Group
            groupsPage.ClickJoinBtn();
            log.Info("Click on Join button to join the Group");
            Thread.Sleep(2000);

            //Now leave the group
            //Click Settings option
            commonPage.ScrollUp();
            groupsPage.ClickSettingsOption();
            Thread.Sleep(2000);
            //Click Settings Options value 'Leave Group'
            groupsPage.ClickSettingsOptionsValues("Leave Group");
            log.Info("Verified Settings option value: 'Leave Group'");
            Thread.Sleep(2000);

            //Click Yes on confirmation message
            groupsPage.PressLeaveGroupWindowYesBtn();
            log.Info("Click on Yes button from Leave Group window.");
            Thread.Sleep(2000);

            //Verify Join button present on the screen or not
            Thread.Sleep(2000);
            groupsPage.VerifyJoinBtn();
            log.Info("Verify the join button on the screen");
        }

        [Test]
        public void Groups_042_ClickDiscussionsAndVerify()
        {
            Global.MethodName = "Groups_042_ClickDiscussionsAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(5000);

            //Verify the Discussion message div
            groupsPage.VerifyDiscussionsMsgDiv();
            log.Info("Verify the Discussion message div.");
            Thread.Sleep(2000);

            //Verify the Discussion Type Text Area(Message Post)
            groupsPage.VerifyDiscussionsTypeMsgDiv();
            log.Info("Verify the Discussion Type Text Area.");
            Thread.Sleep(4000);

            //Click Group's About tab
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_043_PostDiscussionMsgAndVerify()
        {
            Global.MethodName = "Groups_043_PostDiscussionMsgAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(5000);

            //Click Discussion Message Div
            groupsPage.ClickMessageTextArea();
            log.Info("Click message in Discussion.");
            Thread.Sleep(2000);

            //Enter the Message in Text Area
            String typeMessage = readGroups.GetValue("Discussion", "typeMessage");
            groupsPage.EnterMessageTextArea(typeMessage);
            log.Info("Enter message in Discussion.");
            Thread.Sleep(2000);

            //Click the Post button for the message
            groupsPage.ClickMessagePostBtn();
            log.Info("Click the Post button for the message.");
            Thread.Sleep(2000);

            //Verify the Discussion Message Reply button
            groupsPage.VerifyDiscussionMsgReplyBtn();
            log.Info("Verify the Discussion Message Reply button.");
            Thread.Sleep(4000);

            //Click Group's About tab
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_044_UploadDiscussionFileAndVerify()
        {
            Global.MethodName = "Groups_044_UploadDiscussionFileAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(5000);

            //Click Discussion Attachment Icon
            groupsPage.ClickDiscussionAttachIcon();
            log.Info("Click message in Discussion.");
            Thread.Sleep(2000);
            String startupPath = Environment.CurrentDirectory; ;
            startupPath = startupPath + "\\no-testing-required-it-will-work.jpg";
            Console.WriteLine("Start up path: " + startupPath);
            SendKeys.SendWait(@startupPath);
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(5000);

            //Click Group's About tab
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_046_ReplyDiscussionMsgAndVerify()
        {
            Global.MethodName = "Groups_046_ReplyDiscussionMsgAndVerify";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(4000);

            //Click Discussion Message Div
            groupsPage.ClickMessageTextArea();
            log.Info("Click message in Discussion.");
            Thread.Sleep(2000);

            //Enter the Message in Text Area
            String typeMessage = readGroups.GetValue("Discussion", "typeMessage");
            groupsPage.EnterMessageTextArea(typeMessage);
            log.Info("Enter message in Discussion.");
            Thread.Sleep(2000);

            //Click the Post button for the message
            groupsPage.ClickMessagePostBtn();
            log.Info("Click the Post button for the message.");
            Thread.Sleep(2000);

            //Click the Discussion Message Reply button
            groupsPage.ClickMessageReplyBtn();
            log.Info("Click the Discussion Message Reply button.");
            Thread.Sleep(2000);

            groupsPage.PressTabKey();
            Thread.Sleep(2000);
            groupsPage.PressTabKey();
            Thread.Sleep(4000);

            //Enter text in the Discussion Reply Message Text Area
            String typeReplyMessage = readGroups.GetValue("Discussion", "typeReplyMessage");
            groupsPage.EnterMessageReplyTextArea(typeReplyMessage);
            log.Info("Click the Reply Message Text Area");
            Thread.Sleep(2000);

            //Click Group's About tab
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_047_PostDiscussionMsgToAll()
        {
            Global.MethodName = "Groups_047_PostDiscussionMsgToAll";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(4000);

            //Click Discussion Message Div
            groupsPage.ClickMessageTextArea();
            log.Info("Click message in Discussion.");
            Thread.Sleep(2000);

            //Enter the Message in Text Area
            String typeMessage = "@all";
            groupsPage.EnterMessageTextArea(typeMessage);
            log.Info("Enter message in Discussion.");
            Thread.Sleep(2000);

            //Press Enter Key
            groupsPage.PressEnterKey();
            Thread.Sleep(2000);

            //Click the Post button for the message
            groupsPage.ClickMessagePostBtn();
            log.Info("Click the Post button for the message.");
            Thread.Sleep(2000);

            //Click Group's About tab
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_048_PostDiscussionMsgToSingleUser()
        {
            Global.MethodName = "Groups_048_PostDiscussionMsgToSingleUser";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Discussions tab
            groupsPage.ClickGroupDiscussionTab();
            log.Info("Click on Group's Discussion tab.");
            Thread.Sleep(4000);

            //Click Discussion Message Div
            groupsPage.ClickMessageTextArea();
            log.Info("Click message in Discussion.");
            Thread.Sleep(2000);

            //Enter the Message in Text Area
            String singleusername = readGroups.GetValue("TC36_PostDiscussionMsgToSingleUser", "singleusername");
            groupsPage.EnterMessageTextArea(singleusername);
            log.Info("Enter message in Discussion.");
            Thread.Sleep(2000);

            //Press Enter Key
            groupsPage.PressEnterKey();
            Thread.Sleep(2000);

            //Click the Post button for the message
            groupsPage.ClickMessagePostBtn();
            log.Info("Click the Post button for the message.");
            Thread.Sleep(2000);

            //Click Group's About tab
            commonPage.ScrollUp();
            Thread.Sleep(2000);
            groupsPage.ClickGroupAboutTab();
            log.Info("Click on Group's About tab.");
            Thread.Sleep(2000);

            //Delete the group
            DeleteGroup();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_049_MoveToProjectAndCreate()
        {
            Global.MethodName = "Groups_049_MoveToProjectAndCreate";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Projects tab
            groupsPage.ClickGroupProjectTab();
            log.Info("Click on Group's Project tab.");
            Thread.Sleep(5000);

            //Click Add New Project button
            projectsPage.ClickOnAddProjectButton();
            log.Info("Click on Projects add new button under Groups.");
            Thread.Sleep(3000);

            //Enter Project Name
            String projectName = "Random Project Name";
            projectName = projectName + builder;
            projectsPage.EnterProjectName(projectName);
            log.Info("Enter Project Name under Group.");
            Thread.Sleep(2000);

            //Enter Project Description
            projectsPage.EnterProjectDescription("Project Desc under Group");
            log.Info("Enter Project Description under Group.");
            Thread.Sleep(2000);

            //Click Create button for Project
            projectsPage.ClickOnCreateProjectBtn();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_050_MoveToEventAndCreate()
        {
            Global.MethodName = "Groups_050_MoveToEventAndCreate";

            //Create a new group
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String groupName = readGroups.GetValue("AddGroupDetails", "groupNameOriginal");
            groupName = groupName + builder;
            CreateGroup(groupName);
            log.Info("Create a new Group");

            //Click on Events tab
            groupsPage.ClickGroupEventTab();
            log.Info("Click on Group's Events tab.");
            Thread.Sleep(5000);

            //Click Add New Event button
            eventsPage.ClickOnNewEventButton();
            log.Info("Click on Event add new button under Groups.");
            Thread.Sleep(3000);

            //Enter Event Name
            String eventName = "Random Event Name";
            eventName = eventName + builder;
            eventsPage.EnterEventName(eventName);
            log.Info("Enter Event Name under Group.");
            Thread.Sleep(2000);

            //Enter Event Description
            eventsPage.EnterEventDescription("Event Desc under Group");
            log.Info("Enter Event Description under Group.");
            Thread.Sleep(2000);

            //Click Create button for Event
            eventsPage.ClickOnCreateEventBtn();
            Thread.Sleep(2000);
        }

        [Test]
        public void Groups_006_VerifyUploadPhoto()
        {
            Global.MethodName = "Groups_006_VerifyUploadPhoto";

            //Click on the side navigation link 'Groups' 
            Thread.Sleep(5000);
            groupsPage.clickGroupsMenu();
            log.Info("Click on the side navigation link 'Groups'.");

            //Click on Add New Group button
            Thread.Sleep(3000);
            groupsPage.clickOnAddNewGroupButton();
            log.Info("Click on the Add New Group button at Groups page.");

            //Verify the Group Upload Photo option
            Thread.Sleep(4000);
            groupsPage.assertGroupUploadPhoto();
            log.Info("Verify the Group Upload Photo option.");

            //Click the Group Upload Photo option
            Thread.Sleep(2000);
            groupsPage.ClicktGroupUploadPhoto();
            log.Info("Click the Group Upload Photo option.");
            String startupPath = System.IO.Directory.GetCurrentDirectory()+"\\TestData";
            startupPath = startupPath + "\\no-testing-required-it-will-work.jpg";
            Thread.Sleep(2000);
            SendKeys.SendWait(@startupPath);
            Thread.Sleep(2000);
            SendKeys.SendWait(@"{Enter}");
            Thread.Sleep(5000);

            //Click Group Photo Upload Save Button
            groupsPage.ClicktGroupUploadPhotoSaveBtn();
            Thread.Sleep(3000);

            //Cancel Group creation
            Thread.Sleep(2000);
            groupsPage.ClickOnCancelButton();
        }










    }
}