﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            app.Navigator.GoToGroupsPage();

            GroupData newData = new GroupData("zzz");
            newData.Header = null;
            newData.Footer = null;

            if (app.Groups.IsEmptyGroups())
            {
                GroupData group = new GroupData("mmm");
                app.Groups.Create(group);
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            app.Groups.Modify(0, newData);

            List<GroupData> newGroups = app.Groups.GetGroupList();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}
