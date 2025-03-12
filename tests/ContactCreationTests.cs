using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            contactHelper.InitAddNewContact();
            ContactData contact = new ContactData("Anton", "Tester");
            contactHelper.FillContactData(contact);
            contactHelper.SubmitContactCreation();
        }
    }
}
