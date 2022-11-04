using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    internal class PersonalInformation
    {
        private string _name;
        private string _address;
        private int _age;
        private string _phoneNumber;

        public PersonalInformation(string name, string address, int age, string phoneNumber)
        {
            SetName(name);
            SetAddress(address);
            SetAge(age);
            SetPhoneNumber(phoneNumber);
        }
        public string GetName()
        {
            return _name;
        }
        public string GetAddress()
        {
            return _address;
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetPhoneNumber()
        {
            return _phoneNumber;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public void SetAddress(string address)
        {
            _address = address;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public void SetPhoneNumber(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }
    }
}
