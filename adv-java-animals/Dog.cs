using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace adv_java_animals
{
    public class Dog : Pet, Talkable
    {
        private bool Friendly { get; set; }

        public Dog(bool friendly, string name) : base(name)
        {
            Friendly = friendly;
            Name = name;
        }

        public bool isFriendly()
        {
            return Friendly;
        }

        public string getName()
        {
            return Name;
        }

        public string talk()
        {
            return "Bark";
        }

        public string toString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + Friendly;
        }
    }
}
