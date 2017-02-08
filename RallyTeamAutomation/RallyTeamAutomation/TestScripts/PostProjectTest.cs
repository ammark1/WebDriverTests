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
    [Category("PostProject")]
    public class PostProjectTest : BaseTestES
    {
        static ReadData readPostProject = new ReadData("PostProject");

        //SignIn
        private void SignInDifferentUser()
        {
            String userName = readPostProject.GetValue("SignInDifferentUser", "userName");
            String password = readPostProject.GetValue("SignInDifferentUser", "password");
            authenticationPage.SetUserName(userName);
            authenticationPage.SetPassword(password);
            authenticationPage.ClickOnLoginButton();
        }

        //Delete Project
        public void DeleteProject()
        {
            //Click Delete Project Icon
            Thread.Sleep(3000);
            postProjectPage.ClickDeleteProjectIcon();
            Thread.Sleep(2000);

            //Click the Delete Project Window Yes Button
            postProjectPage.PressDeleteProjectWindowYesBtn();
            Thread.Sleep(3000);
        }

        //Post a Project
        public void PostNewProject(String projectName)
        {
            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);                     

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);          
        }

        [Test]
        public void PostProject_001_VerifyPostProjectOption()
        {
            Global.MethodName = "PostProject_001_VerifyPostProjectOption";

            postProjectPage.VerifyPostProjectOption();
            log.Info("Verify Post A Project tab");
        }

        [Test]
        public void PostProject_002_PostANewProject()
        {
            Global.MethodName = "PostProject_002_PostANewProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));            
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);

            //Enter the Project Location
            String projectLocation = readPostProject.GetValue("AddProjectDetails", "projectLocation");
            postProjectPage.EnterProjectLocation(projectLocation);
            Thread.Sleep(1000);

            //Enter Members Needed
            String noOfMembers = readPostProject.GetValue("AddProjectDetails", "noOfMembers");
            postProjectPage.EnterMembersNeeded(noOfMembers);
            Thread.Sleep(1000);

            //Enter Members Needed
            String skillsNeeded = readPostProject.GetValue("AddProjectDetails", "skillsNeeded");
            postProjectPage.EnterSkillsNeeded(skillsNeeded);
            Thread.Sleep(3000);
            commonPage.PressEnterKey();
            Thread.Sleep(1000);

            //Enter Member Name
            String memberName = readPostProject.GetValue("AddProjectDetails", "memberName");
            postProjectPage.EnterMemberName(memberName);
            Thread.Sleep(3000);
            commonPage.PressEnterKey();
            Thread.Sleep(1000);

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Verify About tab of the project after creation
            postProjectPage.VerifyAboutTabOnPage();

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_003_VerifySuggestedMemberFromProjectName()
        {
            Global.MethodName = "PostProject_003_VerifySuggestedMemberFromProjectName";

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName("Testing");
            Thread.Sleep(1000);
            commonPage.PressTabKey();
            Thread.Sleep(5000);

            //Verify the suggested member as per Project Name
            postProjectPage.VerifySuggestedMemberName("bob lawson");
        }

        [Test]
        public void PostProject_004_VerifySuggestedMemberFromProjectDescription()
        {
            Global.MethodName = "PostProject_004_VerifySuggestedMemberFromProjectDescription";

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Description
            postProjectPage.EnterProjectDescription("Testing");
            Thread.Sleep(1000);
            commonPage.PressTabKey();
            Thread.Sleep(5000);

            //Verify the suggested member as per Project Name
            postProjectPage.VerifySuggestedMemberName("bob lawson");
            Thread.Sleep(2000);
        }

        [Test]
        public void PostProject_005_CompleteProject()
        {
            Global.MethodName = "PostProject_005_CompleteProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Select Project status as Completed
            postProjectPage.SelectStatusDropDown("Completed");
            log.Info("Select Project status as 'Completed'");
            Thread.Sleep(4000);

            //Click on Mark Complete button
            postProjectPage.ClickMarkComplete();
            log.Info("Click Mark Complete button.");
            Thread.Sleep(5000);

            //Verify Update Metrics button
            postProjectPage.VerifyUpdateMetricsBtn();
            log.Info("Verify Update Metrics button.");
            Thread.Sleep(1000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_006_MarkProjectInProgress()
        {
            Global.MethodName = "PostProject_006_MarkProjectInProgress";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Select Project status as In Progress
            postProjectPage.SelectStatusDropDown("In Progress");
            log.Info("Select Project status as 'In Progress'");
            Thread.Sleep(5000);            

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_007_MarkProjectClosed()
        {
            Global.MethodName = "PostProject_007_MarkProjectClosed";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Select Project status as Closed
            postProjectPage.SelectStatusDropDown("Closed");
            log.Info("Select Project status as 'Closed'");
            Thread.Sleep(5000);

            //Verify Update Metrics button
            postProjectPage.VerifyUpdateMetricsBtn();
            log.Info("Verify Update Metrics button.");
            Thread.Sleep(1000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_008_EditProject()
        {
            Global.MethodName = "PostProject_008_EditProject";

            //Create a new project
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Edit the Project Name
            Thread.Sleep(2000);
            String editProjectName = readPostProject.GetValue("EditProject", "editProjectName");
            postProjectPage.EditProjectName(editProjectName);
            log.Info("Edit the Project Name.");

            //Edit the Project Location
            Thread.Sleep(2000);
            String editProjectLocation = readPostProject.GetValue("EditProject", "editProjectLocation");
            postProjectPage.EnterProjectLocation(editProjectLocation);
            log.Info("Edit the Project Location.");

            //Edit the Project Owner
            Thread.Sleep(2000);
            String editProjectOwner = readPostProject.GetValue("EditProject", "editProjectOwner");
            postProjectPage.SelectOptionFromProjectOwner(editProjectOwner);
            log.Info("Edit the Project Owner.");
            Thread.Sleep(3000);
        }

        [Test]
        public void PostProject_009_AddMemberToProject()
        {
            Global.MethodName = "PostProject_009_AddMemberToProject";

            //Create a new project
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click on Add member icon
            Thread.Sleep(3000);
            postProjectPage.ClickAddMemberIcon();
            log.Info("Click the Add member icon for the Project.");

            //Enter the Project Member Email
            Thread.Sleep(4000);
            String addMemberEmail = readPostProject.GetValue("AddProjectMember", "addMemberEmail");
            postProjectPage.EnterProjectMemberEmail(addMemberEmail);

            //Select user from suggestion
            Thread.Sleep(2000);
            String addMemberName = readPostProject.GetValue("AddProjectMember", "addMemberName");
            postProjectPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");

            //Click the Add Project Member window Done button
            Thread.Sleep(2000);
            postProjectPage.ClickAddProjectMemberDoneBtn();
            log.Info("Click the Add Project Member window Done button.");

            //Verify the added member confirmation message
            Thread.Sleep(1000);
            postProjectPage.VerifyAddedMemberConfMsg();
            log.Info("Verified Project member added confirmation message.");
            Thread.Sleep(2000);

            //Delete Project
            DeleteProject();
            Thread.Sleep(2000);
        }

        [Test]
        public void PostProject_010_RemoveMemberFromProject()
        {
            Global.MethodName = "PostProject_010_RemoveMemberFromProject";

            //Create a new project
            Thread.Sleep(5000);
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click on Add member icon
            Thread.Sleep(3000);
            postProjectPage.ClickAddMemberIcon();
            log.Info("Click the Add member icon for the Project.");

            //Enter the Project Member Email
            Thread.Sleep(4000);
            String addMemberEmail = readPostProject.GetValue("AddProjectMember", "addMemberEmail");
            postProjectPage.EnterProjectMemberEmail(addMemberEmail);

            //Select user from suggestion
            Thread.Sleep(2000);
            String addMemberName = readPostProject.GetValue("AddProjectMember", "addMemberName");
            postProjectPage.SelectUserfromSuggestion(addMemberName);
            log.Info("User selected successfully.");

            //Click the Add Project Member window Done button
            Thread.Sleep(2000);
            postProjectPage.ClickAddProjectMemberDoneBtn();
            log.Info("Click the Add Project Member window Done button.");

            //Click the added member remove icon
            Thread.Sleep(3000);
            commonPage.ScrollDown();
            Thread.Sleep(1000);
            postProjectPage.ClickAddedMemberRemoveIcon();
            log.Info("Click Project member added remove icon.");

            //Click the Remove Member window Yes Button
            Thread.Sleep(2000);
            postProjectPage.PressRemoveMemberYesBtn();
            log.Info("Click the Remove Project Member window Yes button.");
            Thread.Sleep(4000);

            //Verify Project member is deleted
            postProjectPage.VerifyProjectMemberNameIsDeleted(addMemberName);
            log.Info("Verified Project member is deleted.");
            Thread.Sleep(2000);

            commonPage.ScrollUp();
            Thread.Sleep(2000);

            //Delete Project
            DeleteProject();
            Thread.Sleep(2000);
        }

        [Test]
        public void PostProject_011_RequestToJoinProject()
        {
            Global.MethodName = "PostProject_011_RequestToJoinProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with a different user
            Thread.Sleep(2000);
            SignInDifferentUser();
            log.Info("Sign in with different user.");

            //Enter the Project Name
            Thread.Sleep(5000);
            postProjectPage.SearchProjectName(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            postProjectPage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(15000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(10000);

            //Click Request to Join button displayed on the screen
            postProjectPage.ClickRequestToJoinBtn();
            log.Info("Click Request To Join button displayed on screen.");
            Thread.Sleep(5000);

            //Verify the Request Sent button sisplayed on screen or not
            postProjectPage.AsssertRequestSentBtn();
            log.Info("Verify Request Sent button doisplayed on screen.");
            Thread.Sleep(3000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Login to the application
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Enter the Project Name
            Thread.Sleep(5000);
            postProjectPage.SearchProjectName(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            postProjectPage.ClickSearchBtn();
            log.Info("Click the prSearch button.");
            Thread.Sleep(15000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_012_PostANewPrivateProject()
        {
            Global.MethodName = "PostProject_012_PostANewPrivateProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);

            //Enter the Project Location
            String projectLocation = readPostProject.GetValue("AddProjectDetails", "projectLocation");
            postProjectPage.EnterProjectLocation(projectLocation);
            Thread.Sleep(1000);

            //Select Private Project Checkbox
            postProjectPage.ClickPrivateProjectCheckBox();
            log.Info("Select the Private Project check-box.");

            //Enter Members Needed
            String noOfMembers = readPostProject.GetValue("AddProjectDetails", "noOfMembers");
            postProjectPage.EnterMembersNeeded(noOfMembers);
            Thread.Sleep(1000);

            //Enter Skills Needed
            String skillsNeeded = readPostProject.GetValue("AddProjectDetails", "skillsNeeded");
            postProjectPage.EnterSkillsNeeded(skillsNeeded);
            Thread.Sleep(3000);
            commonPage.PressEnterKey();
            Thread.Sleep(1000);

            //Enter Member Name
            String memberName = readPostProject.GetValue("AddProjectDetails", "memberName");
            postProjectPage.EnterMemberName(memberName);
            Thread.Sleep(3000);
            commonPage.PressEnterKey();
            Thread.Sleep(1000);

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Verify the Private icon on the Projects Page
            postProjectPage.AssertPrivateIcon();
            log.Info("Assert Private Icon.");
            Thread.Sleep(1000);

            //Verify About tab of the project after creation
            postProjectPage.VerifyAboutTabOnPage();

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_013_VerifyNonAdminCannotAccessPrivateProject()
        {
            Global.MethodName = "PostProject_013_VerifyNonAdminCannotAccessPrivateProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = "PrivateProject " + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);                       

            //Select Private Project Checkbox
            postProjectPage.ClickPrivateProjectCheckBox();
            log.Info("Select the Private Project check-box.");
            
            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with Bob Lewis
            authenticationPage.SetUserName("bobl@mailinator.com");
            authenticationPage.SetPassword("Logica360");
            authenticationPage.ClickOnLoginButton();
            Thread.Sleep(5000);

            //Click the Browse button
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(5000);

            //Enter the Project Name
            Thread.Sleep(5000);
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Verify Project is not displayed
            postProjectPage.AssertProjectNotDisplayedMsg();
            log.Info("Verify Project is not displayed.");
            Thread.Sleep(1000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Login to the application
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Click the Browse button
            Thread.Sleep(5000);
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_014_VerifyInvitedUsersCanAccessPrivateProject()
        {
            Global.MethodName = "PostProject_014_VerifyInvitedUsersCanAccessPrivateProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = "Ammar Testing " + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);

            //Select Private Project Checkbox
            postProjectPage.ClickPrivateProjectCheckBox();
            log.Info("Select the Private Project check-box.");

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with Bob Lewis
            authenticationPage.SetUserName("bobl@mailinator.com");
            authenticationPage.SetPassword("Logica360");
            authenticationPage.ClickOnLoginButton();
            Thread.Sleep(5000);

            //Click the Browse button
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click the Project displayed
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project displayed.");
            Thread.Sleep(1000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Login to the application
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Click the Browse button
            Thread.Sleep(5000);
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_015_VerifyAdminCanAccessPrivateProject()
        {
            Global.MethodName = "PostProject_015_VerifyAdminCanAccessPrivateProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = "PrivateProject " + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);

            //Select Private Project Checkbox
            postProjectPage.ClickPrivateProjectCheckBox();
            log.Info("Select the Private Project check-box.");

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with different user
            SignInDifferentUser();
            Thread.Sleep(5000);

            //Click the Browse button
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(5000);

            //Enter the Project Name
            Thread.Sleep(5000);
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(10000);

            //Click the Project displayed
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project displayed.");
            Thread.Sleep(1000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Login to the application
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Click the Browse button
            Thread.Sleep(5000);
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void PostProject_016_ChangeFromPrivateToPublicAndVerify()
        {
            Global.MethodName = "PostProject_016_ChangeFromPrivateToPublicAndVerify";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = "PrivateProject " + builder;

            //Click Post Project tab
            Thread.Sleep(3000);
            postProjectPage.ClickPostProject();
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);

            //Enter the Project Description
            String projectDesc = readPostProject.GetValue("AddProjectDetails", "projectDesc");
            postProjectPage.EnterProjectDescription(projectDesc);
            Thread.Sleep(1000);

            //Select Private Project Checkbox
            postProjectPage.ClickPrivateProjectCheckBox();
            log.Info("Select the Private Project check-box.");

            //Click on the create button
            postProjectPage.ClickOnCreateProjectBtn();
            Thread.Sleep(7000);

            //Click Private Icon
            postProjectPage.ClickPrivateIcon();
            log.Info("Click the private icon of the project.");
            Thread.Sleep(2000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with Bob Lewis
            authenticationPage.SetUserName("bobl@mailinator.com");
            authenticationPage.SetPassword("Logica360");
            authenticationPage.ClickOnLoginButton();
            Thread.Sleep(5000);

            //Click the Browse button
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click Project displayed
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click Project displayed.");
            Thread.Sleep(1000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Login to the application
            Thread.Sleep(5000);
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Click the Browse button
            Thread.Sleep(5000);
            marketplacePage.ClickBrowseBtn();
            log.Info("Click the Browse button.");
            Thread.Sleep(7000);

            //Enter the Project Name
            marketplacePage.EnterSearchField(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(1000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(7000);

            //Click the created project
            postProjectPage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }







    }
}
