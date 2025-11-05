using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace adv_java_animals
{
    public class Teacher : Person, Talkable
    {
        private int Age { get; set; }

        public Teacher(int age, string name) : base(name)
        {
            Age = age;
            Name = name;
        }

        public string getName()
        {
            return Name;
        }

        public string talk()
        {
            return "Don't forget to do the assigned reading!";
        }
    }
}
