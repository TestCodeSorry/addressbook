using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    class ContactData
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string nickName;
        private string title;
        private string company;
        private string address;
        private string phoneNumberHome;
        private string phoneNumberMobile;
        private string phoneNumberWork;
        private string fax;
        private string email;
        private string email2;
        private string email3;
        private string homePage;
        private string bday;
        private string aday;
        private string group;

        public ContactData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string PhoneNumberHome { get; set; }
        public string PhoneNumberMobile { get; set; }
        public string PhoneNumberWork { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string HomePage { get; set; }
        public string Bday { get; set; }
        public string Aday { get; set; }
        public string Group { get; set; }
    }
}
