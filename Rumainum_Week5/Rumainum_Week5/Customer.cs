using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rumainum_Week5
{
    public class Customer : ICloneable
    {
        private string firstName;
        private string lastName;
        private string eMailAddress;

        public Customer()
        {
        }

        public Customer(string firstName, string lastName, string eMailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMailAddress = eMailAddress;
        }

        public string FirstName
        {
            get {
                if (firstName != String.Empty || firstName != null) {
                    return firstName;
                }
                else {
                    throw new ArgumentException("First name is null or empty string", "FirstName");

                }
            }
            set {
                if (firstName != String.Empty || firstName != null) {
                    firstName = value;
                }
                else {
                    throw new ArgumentException("First name cannot be null or empty string", "FirstName");
                }
            }
        }

        public string LastName
        {
            get {
                if (lastName != String.Empty || lastName != null) {
                    return lastName;
                }
                else {
                    throw new ArgumentException("Last name is null or empty string", "LastName");
                }
            }
            set {
                if (lastName != String.Empty || lastName != null) {
                    lastName = value;
                }
                else {
                    throw new ArgumentException("Last name cannot be null or empty string", "LastName");
                }
            }
        }

        public string EMailAddress
        {
            get {
                if (eMailAddress != String.Empty || eMailAddress != null) {
                    return eMailAddress;
                }
                else {
                    throw new ArgumentException("E-mail address is null or empty string", "FirstName");
                }
            }
            set
            {
                if (eMailAddress != String.Empty || eMailAddress != null) {
                    eMailAddress = value;
                }
                else {
                    throw new ArgumentException("E-mail address cannot be null or empty string", "EMailAddress");
                }
            }
        }

        // Getting the currnet customer information
        public string GetCustomerInfo() =>
            this.FirstName + " " + this.LastName + ", " + this.EMailAddress;

        // Cloning object method for new customer to current customer
        public object Clone()
        {
            Customer c = new Customer();
            c.FirstName = this.FirstName;
            c.LastName = this.LastName;
            c.EMailAddress = this.EMailAddress;
            return c;
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName + ", " + this.EMailAddress;
        }

    }
}
