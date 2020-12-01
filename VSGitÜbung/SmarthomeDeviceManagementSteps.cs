using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;
using Xunit;

namespace VSGitÜbung
{
    [Binding]
    public class SmarthomeDeviceManagementSteps
    {
        List<Device> devs = new List<Device>();
        Device dev = new Device("");

        //add
        [Given(@"an empty device list")]
        public void GivenAnEmptyDeviceList()
        {
            devs = new List<Device>();
        }
        
        [When(@"I add (.*) to my device list")]
        public void WhenIAddToMyDeviceList(string p0)
        {
            dev = new Device(p0);
            devs.Add(dev);
        }
        
        [Then(@"there should be (.*) device in my device list")]
        public void ThenThereShouldBeDeviceInMyDeviceList(int p0)
        {
            p0 = devs.Count;
        }
        
        [Then(@"(.*) is in my device list")]
        public void ThenIsInMyDeviceList(string p0)
        {
            devs.Contains(dev);
            
        }

        //delete
        [Given(@"(.*) device is in my device list")]
        public void GivenDeviceIsInMyDeviceList(int p0)
        {
            dev = new Device("<HUE Lampe 1>");
            devs.Add(dev);
        }

        [Given(@"the device is (.*)")]
        public void GivenTheDeviceIs(string p0)
        {
            dev.ToString().Equals(p0);
        }

        [When(@"I delete (.*) from my device list")]
        public void WhenIDeleteFromMyDeviceList(string p0)
        {
            devs.Remove(new Device(p0));
        }

        [Then(@"(.*) is not in my device list")]
        public void ThenIsNotInMyDeviceList(string p0)
        {
            devs.Equals(new Device(p0));
        }

    }
}
