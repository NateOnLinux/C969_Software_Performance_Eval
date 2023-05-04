using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C969_ncarrel
{
    class Validate
    {
        public bool Name(string name) //VARCHAR 45 (Customer Name)
        {
            return name.Length <= 45;
        }
        public bool Phone(string phone) //VARCHAR 20 (Phone)
        {
            Regex phoneNumber = new Regex(@"\(? ([0-9]{3})\)?([.-]?)([0-9]{3})\2([0-9]{4})");
            return phoneNumber.IsMatch(phone);
        }
        public  bool Address(string address) //VARCHAR 50 (Address, Address 2, City, Country)
        {
            if (address is null)
                return false;
            return address.Length <= 50;

        }
        public bool PostalCode(string zip) //VARCHAR 20 (Postal Code)
        {
            Regex postalCode = new Regex(@"([0-9])");
            return postalCode.IsMatch(zip) && zip.Length <= 20;
        }
        public bool Title(string title) //VARCHAR 255 (Title, URL)
        {
            return title.Length < 255;
        }
    }
}
