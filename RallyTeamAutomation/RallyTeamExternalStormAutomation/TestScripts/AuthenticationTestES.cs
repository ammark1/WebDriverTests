using NUnit.Framework;
using RallyTeamExternalStormAutomation.UILocators;
using RallyTeamExternalStormAutomation.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace RallyTeamExternalStormAutomation.TestScripts
{
    [TestFixture]
    [Category("Authentication")]
    public class AuthenticationTestES : BaseTest
    {
        static ReadData readAuthentication = new ReadData("Authentication");

        [Test]
        public void Authentication_Login_001_VerifyLoginUrl()
        {
            Thread.Sleep(2000);
            authenticationPage.VerifyLoginPage();
            log.Info("Verify Login Url Page");
        }

        

        
    }
}