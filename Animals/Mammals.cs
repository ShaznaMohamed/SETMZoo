using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Animals
{
    class Mammals : Animal
    {

        public string place { get; set; }

        public string name
        {
            get { return base.name; }
            set { base.name = value; }
        }

        public int age
        {
            get { return base.age; }
            set { base.age = value; }
        }


    }
}
