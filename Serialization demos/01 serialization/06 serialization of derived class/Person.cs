using System;
using System.Xml.Serialization;

namespace csharp_programming {
    [Serializable]
    //[XmlRoot("PersonDetails")]
    public class Person {
        //[XmlElement("PersonName")]
        public string Name { get; set; }

        //[XmlElement("PersonAge")]
        public int Age { get; set; }

        //[XmlAttribute("Married")]
        public bool Married { get; set; }

        //[XmlIgnore]
        public bool IsGraduate { get; set; }

        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}", Name, Age, Married, IsGraduate);
        }
    }
}
