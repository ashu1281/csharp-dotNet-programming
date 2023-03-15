using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            SerializePersonData();
            DeserializePersonData();
            SerializeListOfPersonsData();
            DeserializeListOfPersonsData();
        }

        private static void DeserializePersonData() {
            var xmlSerializer = new XmlSerializer(typeof(Person));
            using (var loadStream = new FileStream("person.xml", FileMode.Open, FileAccess.Read)) {
                Person person = (Person)xmlSerializer.Deserialize(loadStream);
                loadStream.Close();
                Console.WriteLine(person);
            }
        }

        private static void SerializePersonData() {
            Person person = new Person { Name = "Karan", Age = 26, Married = true, IsGraduate = true };
            var xmlSerializer = new XmlSerializer(typeof(Person));
            using (var saveStream = new FileStream("person.xml", FileMode.Create, FileAccess.Write)) {
                xmlSerializer.Serialize(saveStream, person);
                saveStream.Close();
            }
        }

        private static void DeserializeListOfPersonsData() {
            var xmlSerializer = new XmlSerializer(typeof(List<Person>));
            using (var loadStream = new FileStream("persons.xml", FileMode.Open, FileAccess.Read)) {
                var persons = (List<Person>)xmlSerializer.Deserialize(loadStream);
                loadStream.Close();
                foreach (var person in persons) {
                    Console.WriteLine(person);
                }
            }
        }

        private static void SerializeListOfPersonsData() {
            var persons = new List<Person>{
                new Person { Name = "Ratan", Age = 26, Married = true, IsGraduate = true },
                new Person { Name = "Rahul", Age = 27, Married = true, IsGraduate = false },
                new Person { Name = "Rohit", Age = 22, Married = false, IsGraduate = true }
            };
            var xmlSerializer = new XmlSerializer(typeof(List<Person>));
            using (var saveStream = new FileStream("persons.xml", FileMode.Create, FileAccess.Write)) {
                xmlSerializer.Serialize(saveStream, persons);
                saveStream.Close();
            }
        }
    }
}
