using System;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySerialization obj = new BinarySerialization();
            // obj.Serialization();
            BinaryDeSerialization objDesrialize = new BinaryDeSerialization();
            objDesrialize.DeSerialization();
        }
    }
}
