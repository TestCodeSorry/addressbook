using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;

        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            SecondName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string SecondName { get; set; }
        public string NickName { get; set; }
        public string Title { get; set; }
        public string Company { get; set; }
        public string Address { get; set; }
        public string HomePhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string HomePage { get; set; }
        public string Bday { get; set; }
        public string Aday { get; set; }
        public string Group { get; set; }
        public string Id { get; set; }
        public string AllPhones 
        {
            get
            {
                if (allPhones != null)
                {
                    return allPhones;
                }
                else
                {
                    return (CleanUp(HomePhone) + CleanUp(MobilePhone) + CleanUp(WorkPhone)).Trim();
                }
            }
            set
            {
                allPhones = value;
            }
        }

        public object InRawData { get; set; }


        private string CleanUp(string phone)
        {
            if (phone == null || phone == "")
            {
                return "";
            }
            return Regex.Replace(phone, "[ -()]", "") + "\r\n";
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return FirstName == other.FirstName && SecondName == other.SecondName;
        }

        public override int GetHashCode()
        {
            return FirstName.GetHashCode() + SecondName.GetHashCode();
        }

        public override string ToString()
        {
            return "firstName + lastName = " + FirstName + SecondName;
        }

        public int CompareTo(ContactData other)
        {
            if (other.FirstName == null || other.SecondName == null)
            {
                return 1;
            }

            if (this.FirstName != other.FirstName)
            {
                return FirstName.CompareTo(other.FirstName);
            }
            else if (this.SecondName != other.SecondName)
            {
                return SecondName.CompareTo(other.SecondName);
            }
            return 0;
        }
    }
}
