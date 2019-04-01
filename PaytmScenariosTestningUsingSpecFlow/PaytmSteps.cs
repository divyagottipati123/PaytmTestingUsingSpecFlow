using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace PaytmScenariosTestningUsingSpecFlow
{
    [Binding]
    public class PaytmSteps
    {
        PaytmHomePage pom = new PaytmHomePage();
        [Given(@"I am at the Paytm Home Page")]
        public void GivenIAmAtThePaytmHomePage()
        {
            pom.NavigateToPaytmHomePage();
        }
        
        [Given(@"I Validate Mobile")]
        public void GivenIValidateMobile()
        {
            var Mobilelink = pom.MobileValidation();
            Assert.IsNotNull(Mobilelink);
        }
        
        [Given(@"I Validate Electicity")]
        public void GivenIValidateElecticity()
        {
            var Electricitylink = pom.ElectricityValidation();
            Assert.IsNotNull(Electricitylink);
        }
        
        [Given(@"I validate DTH")]
        public void GivenIValidateDTH()
        {
            var DTHlink = pom.DTHValidation();
            Assert.IsNotNull(DTHlink);
        }
        
        [Given(@"I validate Metro")]
        public void GivenIValidateMetro()
        {
            var Metrolink = pom.MetroValidation();
            Assert.IsNotNull(Metrolink);
        }
        
        [Given(@"I click on mobile Link")]
        public void GivenIClickOnMobileLink()
        {
            pom.Mobilelinkclick();
        }
        
        [Given(@"I have Entered (.*) and (.*)")]
        public void GivenIHaveEnteredAnd(string p0, string p1)
        {
            pom.EnterMobilenumandAmount();
        }
        
        [When(@"I click Proceed to recharge")]
        public void WhenIClickProceedToRecharge()
        {
            pom.Proceedtorecharge();

        }

        [Then(@"Web elements should be validated and It should navigate to '(.*)' page")]
        public void ThenWebElementsShouldBeValidatedAndItShouldNavigateToPage(string p0)
        {
            pom.NavigationtoRechargePage();
        }
        [AfterScenario]
        public void CloseBrowser()
        {
            pom.CloseBrowser();
        }
    }
}
