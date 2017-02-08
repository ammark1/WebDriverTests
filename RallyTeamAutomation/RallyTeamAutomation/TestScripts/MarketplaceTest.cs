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
    [Category("Marketplace")]
    public class MarketplaceTest : BaseTestES
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
            Thread.Sleep(2000);
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
        public void Marketplace_001_SearchProject()
        {
            Global.MethodName = "Marketplace_001_SearchProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
            Thread.Sleep(5000);

            //Click Browse button
            marketplacePage.ClickBrowseBtn();
            log.Info("Click Browse button.");
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.SearchProjectName(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(2000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(12000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);           
           
            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_002_BrowseAndSearchProject()
        {
            Global.MethodName = "Marketplace_002_BrowseAndSearchProject";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_003_VerifyMyProjectsSearch()
        {
            Global.MethodName = "Marketplace_003_VerifyMyProjectsSearch";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);
            
            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select My Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("My Projects");
            log.Info("Select My Projects from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_004_VerifyProjectsIOwnSearch()
        {
            Global.MethodName = "Marketplace_004_VerifyProjectsIOwnSearch";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select My Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Projects I Own");
            log.Info("Select My Projects from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_005_VerifyRecruitingProjectsSearch()
        {
            Global.MethodName = "Marketplace_005_VerifyRecruitingProjectsSearch";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select My Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Recruiting Projects");
            log.Info("Select My Projects from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_006_VerifyRecommendedProjectsSearch()
        {
            Global.MethodName = "Marketplace_006_VerifyRecommendedProjectsSearch";

            //Post a new project
            //Enter the Project Name
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = "Testing Recommended";
            projectName = projectName + builder;
            PostNewProject(projectName);
            postProjectPage.EnterProjectName(projectName);
            Thread.Sleep(1000);
                        
            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");

            //Sign in with a different user
            Thread.Sleep(2000);
            SignInDifferentUser();
            log.Info("Sign in with different user.");

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select Recommended Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Recommended Projects");
            log.Info("Select Recommended Projects from the drop-down.");
            Thread.Sleep(5000);

            //Signout of the application
            Thread.Sleep(5000);
            authenticationPage.SignOut();
            log.Info("Click on the Signout button.");
            Thread.Sleep(5000);

            //Login to the application
            authenticationPage.SetUserName(_workEmail);
            authenticationPage.SetPassword(_password);
            authenticationPage.ClickOnLoginButton();

            //Click Browse button
            Thread.Sleep(5000);
            marketplacePage.ClickBrowseBtn();
            log.Info("Click Browse button.");
            Thread.Sleep(5000);

            //Enter the Project Name
            postProjectPage.SearchProjectName(projectName);
            log.Info("Enter the project name.");
            Thread.Sleep(2000);

            //Click Search button
            marketplacePage.ClickSearchBtn();
            log.Info("Click the Search button.");
            Thread.Sleep(12000);

            //Click the created project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            Thread.Sleep(3000);
            DeleteProject();
        }

        [Test]
        public void Marketplace_007_VerifyInProgressProjectsSearch()
        {
            Global.MethodName = "Marketplace_007_VerifyInProgressProjectsSearch";

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

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select In Progress from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Projects In Progress");
            log.Info("Select In Progress from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_008_VerifyCompletedProjectsSearch()
        {
            Global.MethodName = "Marketplace_008_VerifyCompletedProjectsSearch";

            //Post a new project
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4));
            String projectName = readPostProject.GetValue("AddProjectDetails", "projectName");
            projectName = projectName + builder;
            PostNewProject(projectName);

            //Select Project status as Completed
            postProjectPage.SelectStatusDropDown("Completed");
            log.Info("Select Project status as 'Completed'");
            Thread.Sleep(5000);

            //Click on Mark Complete button
            postProjectPage.ClickCompleteProjectWindow();
            Thread.Sleep(1000);
            commonPage.ScrollDown();
            Thread.Sleep(2000);
            postProjectPage.ClickMarkComplete();
            log.Info("Click Mark Complete button.");
            Thread.Sleep(5000);

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select Completed Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Completed Projects");
            log.Info("Select Completed Projects from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }

        [Test]
        public void Marketplace_009_VerifyClosedProjectsSearch()
        {
            Global.MethodName = "Marketplace_009_VerifyClosedProjectsSearch";

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

            //Click the Marketplace tab
            marketplacePage.ClickMarketplaceTab();
            log.Info("Click the Marketplace tab.");
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

            //Select Closed Projects from the All Projects drop-down
            marketplacePage.SelectAllProjectsDropDown("Closed Projects");
            log.Info("Select Closed Projects from the drop-down.");
            Thread.Sleep(5000);

            //Click the created Project
            marketplacePage.ClickProjectNameOnPage(projectName);
            log.Info("Click the Project Name on the Projects Page.");
            Thread.Sleep(5000);

            //Delete Project
            DeleteProject();
        }
        

    }
}
