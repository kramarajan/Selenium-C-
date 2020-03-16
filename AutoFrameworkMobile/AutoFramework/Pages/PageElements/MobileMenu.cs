namespace AutoFramework.Pages
{
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.PageObjects;

    public class MobileMenu
    {
        public MobileMenu()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-post_type.menu-item-object-page.current-menu-item.page_item.page-item-17.current_page_item.menu-item-25")]
        public IWebElement Introduction { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-taxonomy.menu-item-object-category.menu-item-106")]
        public IWebElement Selectors { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-taxonomy.menu-item-object-category.menu-item-35")]
        public IWebElement SpecialElements { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-taxonomy.menu-item-object-category.menu-item-57")]
        public IWebElement TestCases { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-taxonomy.menu-item-object-category.menu-item-58")]
        public IWebElement TestScenarios { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > nav > div > ul > li.menu-item.menu-item-type-post_type.menu-item-object-page.menu-item-26")]
        public IWebElement About { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#mh-mobile > div > div.mh-header-mobile-nav.clearfix > div > a")]
        public IWebElement OpenMenu { get; set; }

    }
}
