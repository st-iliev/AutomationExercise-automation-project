﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string PageURL => "https://www.automationexercise.com/";
        public IWebElement rightArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-right']"));
        public IWebElement leftArrow => driver.FindElement(By.XPath("//*[@class='fa fa-angle-left']"));
        public IWebElement activeIndicators => driver.FindElement(By.XPath("//*[@id='slider-carousel']/ol"));
        public IWebElement futureItems => driver.FindElement(By.XPath("//*[@class='features_items']"));

        public IWebElement categoryProducts => driver.FindElement(By.XPath("//h2[@class='title text-center']"));
        public IWebElement womenCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Women')]"));
        public IWebElement womenDress => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/1')]"));
        public IWebElement womenTops => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/2')]"));
        public IWebElement womenSaree => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/7')]"));
        public IWebElement menCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Men')]"));
        public IWebElement menTshirts => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/3')]"));
        public IWebElement menJeans => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/6')]"));
        public IWebElement kidsCategory => driver.FindElement(By.XPath("//*[contains(@href, '#Kids')]"));
        public IWebElement kidsDress => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/4')]"));
        public IWebElement kidsTopsAndShirts => driver.FindElement(By.XPath("//*[contains(@href, '/category_products/5')]"));
        public IWebElement brandsPolo => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Polo')]"));
        public IWebElement brandsHAndM => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/H&M')]"));
        public IWebElement brandsMademe => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Mademe')]"));
        public IWebElement brandsMasterAndHarbour => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Master & Harbour')]"));
        public IWebElement brandsBabyhug => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/BabyHug')]"));
        public IWebElement brandsAllenSollyJunior => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Allen Solly Junior')]"));
        public IWebElement brandsKookieKids => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Kookie Kids')]"));
        public IWebElement brandsBiba => driver.FindElement(By.XPath("//*[contains(@href, '/brand_products/Biba')]"));
    }
}