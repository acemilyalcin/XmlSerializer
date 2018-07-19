using System;

namespace XmlSerializationOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Serialization serialize = new Serialization();

            string xmlOutput;

            // Taking studen details from console screen
            Console.WriteLine("Enter student ID :");
            student.ID = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter student name :");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student class :");
            student.Class = Convert.ToInt16(Console.ReadLine());

            // Sending details to method for serializing operations
            xmlOutput = serialize.SerializationOperations(student.ID, student.Name, student.Class);
            Console.Clear();
            Console.WriteLine("{0} \n\n\t Press any key for exit...", xmlOutput);
            Console.ReadKey();
        }
    }
}