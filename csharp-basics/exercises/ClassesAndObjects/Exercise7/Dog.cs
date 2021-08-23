using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Dog
    {
        public string _name;
        public string _sex;
        public string _mother;
        public string _father;
        public Dog (string name,string sex) 
        {
            this._name = name;
            this._sex = sex;
        }
        public Dog(string name, string sex, string mother, string father) 
        {
            this._name = name;
            this._sex = sex;
            this._mother = mother;
            this._father = father;
        }
        public void FathersName()
        {
            if (_father != null) Console.WriteLine(_father);
            else Console.WriteLine("Unknown");
        }
        public bool HasSameMotherAs(Object obj) 
        {
            if (obj == null || !(obj is Dog)) return false;
            else return this._mother == ((Dog)obj)._mother;
        }
    }
}
