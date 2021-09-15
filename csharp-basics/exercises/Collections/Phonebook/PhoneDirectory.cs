using System;
using System.Collections.Generic;
namespace PhoneBook
{
    public class PhoneDirectory
    {
        private SortedDictionary<string, string> _Data;

        public PhoneDirectory()
        {
            _Data = new SortedDictionary<string, string>();
        }

        private bool Find(string name) {
            foreach (var contents in _Data.Keys)
            {
                if (contents.Equals(name))
                    return true;
            }
            return false;
        }

        public string GetNumber(string name) 
        {
            var position = Find(name);
            if (position == false)
                return null;
            else
                return _Data[name];
        }

        public void PutNumber(string name, string number) 
        {
            if (name == null || number == null)
                throw new Exception("name and number cannot be null");

            var i = Find(name);
            if (i == true)
                _Data[name] = number;
            else 
            {
                var newEntry = new PhoneEntry {name = name, number = number};
                _Data.Add(newEntry.name, newEntry.number);
            }
        }
    }
}