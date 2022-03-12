using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Runtime.Serialization;

//using static System.Console;
namespace Seriz
{
    [Serializable]
    class Creationn
    {
        public Creationn()
        {
            //не пригодилось но удалять не стал 
            //Student one = new Student("das", 23, "asd");
            //Console.WriteLine(one.ToString());

            //string filePath = "test.txt";
            //FileStream fs = new FileStream(filePath, FileMode.Create);    /*using работает только в майн тут нет*/
            //StreamWriter sw = new StreamWriter(fs);
            //sw.WriteLine(one.ToString());
            //sw.Close();               /*пока 2 потока не закроешь работать не будет*/
            //fs.Close();

            //string filePart1 = "ivan.stu";
            //FileStream fs1 = new FileStream(filePart1, FileMode.Create);
            //BinaryWriter sw1 = new BinaryWriter(fs1, Encoding.Unicode);

            //sw1.Write(one.ToString());
            //sw1.Close();
            //fs1.Close();

            Console.WriteLine("Один студент");
            Student aa = new Student("Alehander", 23, "BV121");
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = File.OpenWrite("test.bin"))
                formatter.Serialize(stream, aa);

            Student aa1;  // специально создаем для проверки работоспособности программы

            using (Stream stream = File.OpenRead("test.bin"))
                aa1 = (Student)formatter.Deserialize(stream);
            Console.WriteLine(aa1.ToString());

            Console.WriteLine();
            Console.WriteLine("Список из студентов");
            List<Student> one = new List<Student>() {
                  new Student("Alehander0", 23, "BV121"),
                  new ("Alehander1", 23, "BV121"),
                  new Student ("Alehander2", 23, "BV121"),
                 new Student ("Alehander3", 23, "BV121")
            };

            using (Stream stream = File.OpenWrite("test1.txt"))
                formatter.Serialize(stream, one);
            List<Student> aaa1;  // специально создаем для проверки работоспособности программы


            using (Stream stream = File.OpenRead("test1.txt"))
                aaa1 = (List<Student>)formatter.Deserialize(stream);


            foreach (var one1 in aaa1)
            {
                Console.WriteLine(one1.ToString());
            }

            Console.WriteLine();

            Console.WriteLine("Учителя и студенты");
            var two = new List<IOne>() {
              new Teacher("Teacher", "Matematika"),
              new Teacher("Teacher", "Histori"),
              new Student ("one", 23, "BV121"),
              new Student ("two", 23, "BV121")
            };
           
            using (Stream stream = File.OpenWrite("teacher.bin"))
                formatter.Serialize(stream, two);
            
            List<IOne> two2;   

            using (Stream stream = File.OpenRead("teacher.bin"))
                two2 = (List<IOne>)formatter.Deserialize(stream);

            foreach (var two1 in two2)
            {
                Console.WriteLine(two1.ToString());
            }

        }


    }
        
        


    
    
}
