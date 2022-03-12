using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seriz
{
    [Serializable]
    class Student
    {
       private string Name { get; set; }
       private int Vozrast { get; set; }
        private string Gruppa { get; set; }

        public Student(string a,int b,string c)
        {
            this.Name = a;
            this.Vozrast = b;
            this.Gruppa = c;
        }

       

        public virtual string ToString()
        {
            return $"{Name} {Vozrast} {Gruppa}";
        }
    }
}
