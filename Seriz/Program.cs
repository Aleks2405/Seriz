using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection;
using System.Runtime.Serialization;

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
            Creationn aa = new Creationn();
            IFormatter formatter = new BinaryFormatter();
            //using (Stream stream = File.OpenWrite("tessst.txt"))
            //    formatter.Serialize(stream, aa);

            Console.WriteLine(aa.ToString());
            using (Stream stream = File.OpenRead("test.txt"))
                aa = (Creationn)formatter.Deserialize(stream);
            Console.WriteLine(aa);
        }
    }
}
