using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    class Student
    {
        public Student(string name, string reg, string @class, string section)
        {
            this.name = name;
            this.reg = reg;
            this.@class = @class;
            this.section = section;
        }

        public string name { get; set; }
        public string reg { get; set; }
        public string @class { get; set; }
        public string section { get; set; }



    }
}
