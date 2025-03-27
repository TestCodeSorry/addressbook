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

            if (app.Contact.IsEmptyContacts())
            {
                ContactData contact = new ContactData("Create", "Remove");
                app.Contact.Create(contact);
            }
            app.Contact.Remove(0);
        }
    }
}
