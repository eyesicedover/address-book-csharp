using System.Collections.Generic;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _address;
        private int _id;
        private static List<Contact> _instances = new List<Contact> {};

        public Contact (string name, string phoneNumber, string address)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            _address = address;
            _id = _instances.Count;
            _instances.Add(this);
        }

        private void SetName(string newName)
        {
            _name = newName;
        }

        private string GetName()
        {
            return _name;
        }

        private void SetPhoneNumber(string newPhone)
        {
            _phoneNumber = newPhone;
        }

        private string GetPhoneNumber()
        {
            return _phoneNumber;
        }

        private void SetAddress(string newAddress)
        {
            _address = newAddress;
        }

        private string GetAddress()
        {
            return _address;
        }

        private void SetId(int newId)
        {
            _id = newId;
        }

        private string GetId()
        {
            return _id;
        }
    }
}
