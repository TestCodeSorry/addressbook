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

            if (app.Contact.IsEmptyContacts())
            {
                ContactData contact = new ContactData("Maxim", "Petrov");
                app.Contact.Create(contact);
            }
            app.Contact.Modify(0);
        }
    }
}
