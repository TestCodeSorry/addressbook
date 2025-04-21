using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupModificationTests : GroupTestBase
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
            List<GroupData> oldGroups = GroupData.GetAll();
            GroupData oldData = oldGroups[0];
            GroupData toBeModify = oldGroups[0];
            app.Groups.Modify(toBeModify, newData);

            Assert.AreEqual(oldGroups.Count, app.Groups.GetGroupCount());

            List<GroupData> newGroups = GroupData.GetAll();
            oldGroups[0].Name = newData.Name;
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);

            foreach (GroupData group in newGroups)
            {
                if (group.Id == oldData.Id) 
                { 
                    Assert.AreEqual(newData.Name, group.Name);
                }
            }
        }
    }
}
