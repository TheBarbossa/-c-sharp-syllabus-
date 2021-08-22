using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    public class Dog
    {
        public string Name;
        public string Sex;
        public string Mother;
        public string Father;
        public Dog (string name,string sex) 
        {
            this.Name = name;
            this.Sex = sex;
        }
        public Dog(string name, string sex, string mother, string father) 
        {
            this.Name = name;
            this.Sex = sex;
            this.Mother = mother;
            this.Father = father;
        }
        public void FathersName()
        {
            if (Father != null) Console.WriteLine(Father);
            else Console.WriteLine("Unknown");
        }
        public bool HasSameMotherAs(Object obj) 
        {
            if (obj == null || !(obj is Dog)) return false;
            else return this.Mother == ((Dog)obj).Mother;
        }
    }
}
