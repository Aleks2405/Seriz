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
            Creationn one = new Creationn();
       

        }
    }
}
