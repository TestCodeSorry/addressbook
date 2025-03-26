using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();

            ContactData contact = new ContactData("Maxim", "Petrov");

            if (!app.Contact.IsEmptyContacts())
            {
                app.Contact.Remove(0);
            }
            else
            {
                app.Contact.Create(contact);
                app.Contact.Remove(0);
            }
        }
    }
}
