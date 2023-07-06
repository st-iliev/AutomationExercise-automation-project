﻿using OpenQA.Selenium;

namespace Automation_Exercise.Pages.CartPage
{
    partial class CartPage
    {
        public IList<WebElement> productList => (IList<WebElement>)driver.FindElement(By.XPath("//*[@id='cart_info_table']/tbody/tr"));
        //public IList<WebElement> productsName => (IList<WebElement>)driver.FindElement(By.XPath("//*[@class='cart_description']/p"));
       // public IList<WebElement> productsPrice => (IList<WebElement>)driver.FindElement(By.XPath("//*[@class='cart_price']/p")); 
       // public IList<WebElement> productQuantity => (IList<WebElement>)driver.FindElement(By.XPath("//*[@class='cart_quantity']/button")); 
       // public IList<WebElement> productTotalPrice => (IList<WebElement>)driver.FindElement(By.XPath("//*[@class='cart_total']/p")); 
       // public IList<WebElement> removeProductFromOrder => (IList<WebElement>)driver.FindElement(By.XPath("//*[@class='cart_delete']/a"));
        public IWebElement proceedToCheckoutButton => driver.FindElement(By.XPath("//a[@class='btn btn-default check_out']"));
        public IWebElement continueOnCardButton => driver.FindElement(By.XPath("//button[@class='btn btn-success close-checkout-modal btn-block']"));
        public IWebElement loginRegister => driver.FindElement(By.XPath("//p[contains(@href,'/login']"));
        public IWebElement emptyCartMessage => driver.FindElement(By.XPath("//span[@id='empty_cart']/p"));
        public IWebElement homeButton => driver.FindElement(By.XPath("//*[@id='cart_items']//a[contains(text(),'Home')]"));
        public IWebElement loginMessage => driver.FindElement(By.XPath("//*[@class='modal-body']/p[1]"));
        public IWebElement registerLoginLink => driver.FindElement(By.XPath("//*[@class='modal-body']/p[2]"));
        public IWebElement continueOnCartButton => driver.FindElement(By.XPath("//button[@data-dismiss='modal']/p[2]"));


    }
}