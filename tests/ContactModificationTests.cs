using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Navigator.GoToHomePage();

            ContactData contact = new ContactData("Maxim", "Petrov");

            if (!app.Contact.IsEmptyContacts())
            {
                app.Contact.Modify(0);
            }
            else
            {
                app.Contact.Create(contact);
                app.Contact.Modify(0);
            }
        }
    }
}
