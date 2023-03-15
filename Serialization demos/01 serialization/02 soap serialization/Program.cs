using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            SerializePersonData();
            DeserializePersonData();
            SerializeListOfPersonsData();
            DeserializeListOfPersonsData();
        }

        private static void DeserializePersonData() {
            IFormatter soapFormatter = new SoapFormatter();
            using (var loadStream = new FileStream("person.soap", FileMode.Open, FileAccess.Read)) {
                var person = (Person) soapFormatter.Deserialize(loadStream) ;
                loadStream.Close();
                Console.WriteLine(person);
            }
        }

        private static void SerializePersonData() {
            var person = new Person { Name = "Karan", Age = 26, Married = true };
            IFormatter soapFormatter = new SoapFormatter();
            using (var saveStream = new FileStream("person.soap", FileMode.Create, FileAccess.Write)) {
                soapFormatter.Serialize(saveStream, person);
                saveStream.Close();
            }
        }

        private static void DeserializeListOfPersonsData() {
            var soapFormatter = new SoapFormatter();
            using (var loadStream = new FileStream("persons.soap", FileMode.Open, FileAccess.Read)) {
                var persons = (Person[])soapFormatter.Deserialize(loadStream);
                loadStream.Close();
                foreach (var person in persons) {
                    Console.WriteLine(person);
                }
            }
        }

        private static void SerializeListOfPersonsData() {
            var persons = new[] {
                new Person { Name = "Ratan", Age = 26, Married = true, IsGraduate = true },
                new Person { Name = "Rahul", Age = 27, Married = true, IsGraduate = false },
                new Person { Name = "Rohit", Age = 22, Married = false, IsGraduate = true }
            };
            var soapFormatter = new SoapFormatter();
            using (var saveStream = new FileStream("persons.soap", FileMode.Create, FileAccess.Write)) {
                soapFormatter.Serialize(saveStream, persons);
                saveStream.Close();
            }
        }
    }
}
