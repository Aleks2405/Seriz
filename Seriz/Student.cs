using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Seriz
{
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

        //string filePath = "test.txt";
        //   FileStream fs = new FileStream(filePath, FileMode.Create);    /*using работает только в майн тут нет*/ 
        //   StreamWriter sw = new StreamWriter(fs);
        //   sw.WriteLine(one.ToString());         
        //   sw.Close();               /*пока 2 потока не закроешь работать не будет*/
        //   fs.Close();

        //   string filePart1 = "ivan.stu";
        //   FileStream fs1 = new FileStream(filePart1, FileMode.Create);
        //   BinaryWriter sw1 = new BinaryWriter(fs1,Encoding.Unicode);

        //   sw1.Write(one.ToString());
        //   sw1.Close();
        //   fs1.Close();

        public virtual string ToString()
        {
            return $"{Name} {Vozrast} {Gruppa}";
        }
    }
}
