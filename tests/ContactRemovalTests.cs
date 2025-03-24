﻿using System;
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
            if (!app.Contact.IsEmptyContacts())
            {
                app.Contact.Remove(1);
                app.Navigator.GoToHomePage();
            }
        }
    }
}
