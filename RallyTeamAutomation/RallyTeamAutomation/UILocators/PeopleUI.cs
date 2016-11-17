using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyTeam.UILocators
{
    public static class PeopleUI
    {

        public readonly static By searchBox = By.XPath("//form[contains(@class, 'rt-user-search')]//input[contains(@class, 'rt-user-search')]");
        public readonly static By advanceLink = By.XPath("//a[text()='advanced']");
        public readonly static By userContainer = By.XPath("//div[@class='rt-user-container']");
        public static By userContainerUserName(String variable)
        {
            return By.XPath("//div[@class='rt-user-container']//strong[contains(text(), '" + variable + "')]");
        }
        public readonly static By messageBtn = By.XPath("//a[text() ='Message']");
        public readonly static By viewProfileBtn = By.XPath("//a[text() ='View Profile']");
        public readonly static By newMessageWindow = By.XPath("//div[@class= 'modal-content']//div[contains(text(), 'New Message')]");
        public readonly static By msgTextAera = By.XPath("//div[@class='modal-content']//textarea[@name ='body']");
        public readonly static By sendMessageBtn = By.XPath("//strong[text() ='Send']");
        public readonly static By messageConversationWindow = By.XPath("//div[text() ='Message Conversation']");
        public static By messagePosted(String variable)
        {
            return By.XPath("//div[contains(text(), '" + variable + "')]");
        }

        //Advance Search
        public readonly static By name = By.Name("location");
        public readonly static By skillsNeeded = By.XPath("//input[@placeholder= 'What skills are you looking for?']");
        public readonly static By jobFunction = By.XPath("//input[@placeholder= 'What job positions are you looking for?']");
        public readonly static By location = By.XPath("//input[@placeholder= 'I am looking for people in these locations...']");
        public readonly static By advSearchIndustryDomain = By.XPath("//tags-input[contains(@placeholder, 'looking for experts in these industries or domains')]");
        public readonly static By endorsedBy = By.XPath("//input[@placeholder= 'I am looking for people who were endorsed by...']");
        public readonly static By availability = By.XPath("//div[@class= 'row m-b-sm']//div[1]//select");
        public readonly static By type = By.XPath("//div[@class= 'row m-b-sm']//div[2]//select");
        public readonly static By searchBtn = By.XPath("//a[text()= 'Search']");

        //User Profile
        public static By userName(String variable)
        {
            return By.XPath("//div[contains(@class, 'rt-user-profile__details__name') and contains(text(), '" + variable + "')]");
        }
        public readonly static By topSkills = By.XPath("//div[text() ='Top Skills']");
        public readonly static By userProfileMessageBtn = By.XPath("//button[text() ='Message']");
        public readonly static By aboutMe = By.XPath("//div[text() ='About Me']");
        public readonly static By skillsANdEndorsements = By.XPath("//div[contains(text(), 'Skills')]");
        public readonly static By industryDomain = By.XPath("//div[text() ='Industry/Domain Expertise']");
        public readonly static By languages = By.XPath("//div[text() ='Languages']");
        public readonly static By interests = By.XPath("//div[text() ='Interests']");
        public readonly static By projects = By.XPath("//div[text() ='Projects']");
    }
}
