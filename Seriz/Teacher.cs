using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seriz
{
    [Serializable]
    class Teacher : IOne
    {
        private string Name_tech { get; set; }
        private string Predmet { get; set; }

        public Teacher(string a, string b)
        {
            this.Name_tech = a;
            this.Predmet = b;
        }

        public override string ToString()
        {
            return $"{Name_tech} {Predmet}";
        }
    }
}
