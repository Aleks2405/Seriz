using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Runtime.Serialization;
using System.Collections.Generic;

//Используйте сериализацию, чтобы сохранить студента Ивана в отдельный файл ivan.stu.
//Отредактируйте файл и загрузите изменённого студента из файла, используя десериализацию.
//Создайте коллекцию студентов и сохраните в файл коллекцию целиком,
//используя граф сериализации.
//Загрузите коллекцию студентов из файла с помощью десериализации.
//★ Сериализуйте и десериализуйте Школу. Школа состоит из преподавателей и студентов.

namespace Seriz
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            //Student  aa = new Student("Alehander", 23, "BV121");
            // IFormatter formatter = new BinaryFormatter();
            // using (Stream stream = File.OpenWrite("test.bin"))
            //     formatter.Serialize(stream, aa);

            // Student aa1;  // специально создаем для проверки работоспособности программы

            // Console.WriteLine(aa.ToString());   // проверка что стало после сереализации
            // using (Stream stream = File.OpenRead("test.bin"))
            //     aa1 = (Student)formatter.Deserialize(stream);
            // Console.WriteLine(aa1.ToString());

            List<Student> one = new List<Student>() {
              new Student("Alehander", 23, "BV121"),
              new ("Alehander1", 23, "BV121"),
              new Student ("Alehander2", 23, "BV121"),
             new Student ("Alehander3", 23, "BV121")
        };
        
        }
    }
}
