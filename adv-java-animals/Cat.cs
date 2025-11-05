using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace adv_java_animals
{
    public class Cat : Pet, Talkable
    {
        private int MousesKilled { get; set; }

        public Cat(int mousesKilled, string name) : base(name)
        {
            MousesKilled = mousesKilled;
            Name = name;
        }

        public void addMouse()
        {
            MousesKilled++;
        }

        public string getName()
        {
            return Name;
        }

        public string talk()
        {
            return "Meow";
        }

        public string toString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }
    }
}
