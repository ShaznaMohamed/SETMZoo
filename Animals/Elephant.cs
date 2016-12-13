using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Elephant : Mammals
    {
        public string place
        {
            get { return base.place; }
            set { base.place = value; }
        }
    }
}
