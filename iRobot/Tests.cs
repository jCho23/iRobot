using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Net.Mail;

namespace iRobot
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("userAgreementCheckbox");
			app.Screenshot("Lets start by Checking the License Agreement");

			app.Tap("App Language");
			app.Screenshot("Then we Tapped on 'App Language");
			app.Tap("English");
			app.Screenshot("Then we Tapped on 'English' as our language");

			app.Tap("emailSignup");
			app.Screenshot("Then we Tapped on 'E-Mail Signup'");
			app.Tap("emailInput");
			app.Screenshot("Next we Tapped on the e-mail text field");


			app.EnterText("ColinM.Angle@irobot.com");
			app.Screenshot("Then we entered our e-mail, 'ColinM.Angle@irobot.com'");
			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			app.Tap("signUpButton");
			app.Screenshot("Then we Tapped on the 'Sign Up' Button");
			app.Tap("button1");
			app.Tap("signUpButton");

			app.Tap("aboutApp");
			app.Screenshot("Next we Tapped on 'About App'");
			app.Back();
			app.Screenshot("We Tapped the 'Back' Button");

			app.Tap("nextButton");
			app.Screenshot("Then we Tapped on the 'Next' Button");
		}

	}
}
