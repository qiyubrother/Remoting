using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    [Serializable]
    public class Person
    {
        public int ID
        {
            get;
            set;
        }

        public String Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }
    }
}
