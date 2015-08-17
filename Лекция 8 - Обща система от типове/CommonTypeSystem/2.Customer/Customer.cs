using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Customer
{
    internal class Customer

    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string EmailAddress { get; set; }
        public LinkedList<Payment> Payments { get; set; }
        public CustomerType CustomerType { get; set; }

        public Customer(string firstName, string middleName, string lastName, int id,
            string permanentAddress, string mobilePhone, string emailAddress, LinkedList<Payment> payments,
            CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.ID = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EmailAddress = emailAddress;
            this.Payments = new LinkedList<Payment>();
            this.CustomerType = customerType;
        }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }
            if (this.ID != customer.ID)
            {
                return false;
            }
            if (!Object.Equals(this.PermanentAddress, customer.PermanentAddress))
            {
                return false;
            }
            if (!Object.Equals(this.MobilePhone, customer.MobilePhone))
            {
                return false;
            }
            if (!Object.Equals(this.EmailAddress, customer.EmailAddress))
            {
                return false;
            }
            if (!Object.Equals(this.Payments, customer.Payments))
            {
                return false;
            }
            if (this.CustomerType != customer.CustomerType)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1,customer2));
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^
                   this.ID.GetHashCode() ^
                   this.PermanentAddress.GetHashCode() ^ this.MobilePhone.GetHashCode() ^
                   this.EmailAddress.GetHashCode() ^ this.Payments.GetHashCode() ^
                   this.CustomerType.GetHashCode();
        }
    }
}
