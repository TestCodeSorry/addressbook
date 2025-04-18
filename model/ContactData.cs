using System;
using System.Collections.Generic;
using System.Linq;
using LinqToDB.Mapping;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    [Table(Name = "addressbook")]
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string allPhones;

        public ContactData(string firstName, string lastName)
        {
            FirstName = firstName;
            SecondName = lastName;
        }

        [Column(Name = "firstname"), NotNull]
        public string FirstName { get; set; }

        [Column(Name = "middlename"), NotNull]
        public string MiddleName { get; set; }

        [Column(Name = "lastname"), NotNull]
        public string SecondName { get; set; }

        [Column(Name = "nickname"), NotNull]
        public string NickName { get; set; }

        [Column(Name = "title"), NotNull]
        public string Title { get; set; }

        [Column(Name = "company"), NotNull]
        public string Company { get; set; }

        [Column(Name = "address"), NotNull]
        public string Address { get; set; }

        [Column(Name = "home"), NotNull]
        public string HomePhone { get; set; }

        [Column(Name = "mobile"), NotNull]
        public string MobilePhone { get; set; }

        [Column(Name = "work"), NotNull]
        public string WorkPhone { get; set; }

        [Column(Name = "fax"), NotNull]
        public string Fax { get; set; }

        [Column(Name = "email"), NotNull]
        public string Email { get; set; }

        [Column(Name = "email2"), NotNull]
        public string Email2 { get; set; }

        [Column(Name = "email3"), NotNull]
        public string Email3 { get; set; }

        [Column(Name = "homepage"), NotNull]
        public string HomePage { get; set; }

        [Column(Name = "bday"), NotNull]
        public string Bday { get; set; }

        [Column(Name = "aday"), NotNull]
        public string Aday { get; set; }

        [Column(Name = "group_id"), NotNull]
        public string Group { get; set; }

        [Column(Name = "id"), PrimaryKey, Identity]
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

        public object InRowData { get; set; }


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
