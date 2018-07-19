using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace XmlSerializationOperations
{
    public class Serialization
    {
        public string SerializationOperations(int ID, string Name, int Class) {
            Student student = new Student();

            student.ID = ID;
            student.Name = Name;
            student.Class = Class;

            XmlSerializer newSerializer = new XmlSerializer(typeof(Student));
            TextWriter newTextWriter = new StringWriter();
            newSerializer.Serialize(newTextWriter, student);

            return newTextWriter.ToString();
        }
    }
}
