using System;
using System.IO;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinarySerialization obj = new BinarySerialization();
            obj.Serialization();
            BinaryDeSerialization obj1 = new BinaryDeSerialization();
            obj1.DeSerialization();
        }


    }
}
