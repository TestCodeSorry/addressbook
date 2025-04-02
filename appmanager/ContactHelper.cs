using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace WebAddressbookTests
{
    public class ContactHelper : HelperBase
    {
        public ContactHelper(ApplicationManager manager) : base(manager )
        {
        }

        public ContactHelper Create(ContactData contact)
        {
            InitAddNewContact();
            FillContactData(contact);
            SubmitContactCreation();
            manager.Navigator.GoToHomePage();
            return this;
        }
        public ContactHelper Modify(int p)
        {
            SelectContact(p);
            InitContactModification();
            EditContactData();
            return this;
        }


        public ContactHelper Remove(int p)
        {
            SelectContact(p);
            RemoveContact();
            return this;
        }

        public ContactHelper FillContactData(ContactData contact)
        {
            Type(By.Name("firstname"), contact.FirstName);
            Type(By.Name("middlename"), "WaitWait");
            Type(By.Name("lastname"), contact.LastName);
            Type(By.Name("nickname"), "Testerovwik");
            Type(By.Name("title"), "adressbook");
            Type(By.Name("company"), "software-testing");
            Type(By.Name("address"), "spb pushkina street 1");
            Type(By.Name("home"), "8126574839");
            Type(By.Name("mobile"), "+78881111111");
            Type(By.Name("work"), "1234");
            Type(By.Name("fax"), "4321");
            Type(By.Name("email"), "test@mail.ru");
            Type(By.Name("email2"), "test2@mail.ru");
            Type(By.Name("email3"), "test3@mail.ru");
            Type(By.Name("homepage"), "www.pentagon.ru");
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("19");
            driver.FindElement(By.XPath("//option[@value='19']")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            driver.FindElement(By.XPath("//option[@value='January']")).Click();
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys("2000");
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("25");
            driver.FindElement(By.XPath("//div[@id='content']/form/select[3]/option[27]")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("August");
            driver.FindElement(By.XPath("//div[@id='content']/form/select[4]/option[9]")).Click();
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys("2000");
            //new SelectElement(driver.FindElement(By.Name("new_group"))).SelectByText("aaa");
            //driver.FindElement(By.XPath("//div[@id='content']/form/select[5]/option[2]")).Click();
            //driver.FindElement(By.XPath("//div[@id='content']/form/input[20]")).Click();
            return this;
        }

        public ContactHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//input[@value='Enter']")).Click();
            return this;
        }

        public ContactHelper InitAddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public ContactHelper SelectContact(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            return this;
        }
        public ContactHelper InitContactModification()
        {
            driver.FindElement(By.XPath("//img[@alt='Edit']")).Click();
            return this;
        }

        public ContactHelper EditContactData()
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys("Standart");
            driver.FindElement(By.Name("middlename")).Click();
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys("Edit");
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys("Modification");
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("nickname")).Clear();
            driver.FindElement(By.Name("nickname")).SendKeys("UP");
            driver.FindElement(By.Name("title")).Click();
            driver.FindElement(By.Name("title")).Clear();
            driver.FindElement(By.Name("title")).SendKeys("update");
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys("apple");
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys("Moscow, Kremlin 1");
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("home")).Clear();
            driver.FindElement(By.Name("home")).SendKeys("84951234345");
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys("+78882222222");
            driver.FindElement(By.Name("work")).Click();
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys("2333");
            driver.FindElement(By.Name("fax")).Click();
            driver.FindElement(By.Name("fax")).Clear();
            driver.FindElement(By.Name("fax")).SendKeys("3444");
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys("update@mail.ru");
            driver.FindElement(By.Name("email2")).Click();
            driver.FindElement(By.Name("email2")).Clear();
            driver.FindElement(By.Name("email2")).SendKeys("update2@mail.ru");
            driver.FindElement(By.Name("email3")).Click();
            driver.FindElement(By.Name("email3")).Clear();
            driver.FindElement(By.Name("email3")).SendKeys("update3@mail.ru");
            driver.FindElement(By.Name("homepage")).Click();
            driver.FindElement(By.Name("homepage")).Clear();
            driver.FindElement(By.Name("homepage")).SendKeys("www.update.ru");
            driver.FindElement(By.Name("bday")).Click();
            new SelectElement(driver.FindElement(By.Name("bday"))).SelectByText("20");
            driver.FindElement(By.XPath("//option[@value='19']")).Click();
            driver.FindElement(By.Name("bmonth")).Click();
            new SelectElement(driver.FindElement(By.Name("bmonth"))).SelectByText("January");
            driver.FindElement(By.XPath("//option[@value='January']")).Click();
            driver.FindElement(By.Name("byear")).Click();
            driver.FindElement(By.Name("byear")).Clear();
            driver.FindElement(By.Name("byear")).SendKeys("2001");
            driver.FindElement(By.Name("aday")).Click();
            new SelectElement(driver.FindElement(By.Name("aday"))).SelectByText("25");
            driver.FindElement(By.XPath("//div[@id='content']/form/select[3]/option[27]")).Click();
            driver.FindElement(By.Name("amonth")).Click();
            new SelectElement(driver.FindElement(By.Name("amonth"))).SelectByText("August");
            driver.FindElement(By.XPath("//div[@id='content']/form/select[4]/option[9]")).Click();
            driver.FindElement(By.Name("ayear")).Click();
            driver.FindElement(By.Name("ayear")).Clear();
            driver.FindElement(By.Name("ayear")).SendKeys("2002");
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public bool IsEmptyContacts()
        {
            if (driver.Url == "http://localhost/addressbook/" && IsElementPresent(By.Name("selected[]")))
            { 
                return false; 
            }
            return true;
        }

        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactList()
        {
            if (contactCache == null)
            {
                contactCache = new List<ContactData>();//List<ContactData> contacts = new List<ContactData>();
                manager.Navigator.GoToHomePage();
                ICollection<IWebElement> table = driver.FindElements(By.Name("entry"));
                foreach (IWebElement row in table)
                {
                    IList<IWebElement> cells = row.FindElements(By.TagName("td"));
                    string firstName = cells[2].Text;
                    string lastName = cells[1].Text;
                    contactCache.Add(new ContactData(firstName, lastName));
                }
            }
            
            return new List<ContactData>(contactCache);
        }
    }
}
 