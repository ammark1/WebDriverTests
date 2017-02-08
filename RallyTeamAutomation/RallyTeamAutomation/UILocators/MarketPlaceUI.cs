using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RallyTeam.UILocators
{
    public static class MarketPlaceUI
    {
        public readonly static By marketplaceTab = By.XPath("//a[text()= 'MARKETPLACE']");
        public readonly static By browseBtn = By.XPath("//a[text()= 'Browse Projects']");
        public readonly static By searchText = By.XPath("//input[contains(@placeholder, 'What kind of project are you looking for?')]");
        public readonly static By searchBtn = By.XPath("//span[contains(text(), 'Search')]");
        public readonly static By searchProjBtn = By.XPath("//a[text()= 'Search']"); 
        public readonly static By allProjectsDropDown = By.XPath("//select[contains(@class, 'marketplace__search-filter')]");







    }
}
