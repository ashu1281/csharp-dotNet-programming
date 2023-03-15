using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            SerializePersonData();
            DeserializePersonData();
            SerializeListOfPersonsData();
            DeserializeListOfPersonsData();
        }

        private static void DeserializePersonData() {
            IFormatter binaryFormatter = new BinaryFormatter();
            using (var loadStream = new FileStream("person.bin", FileMode.Open, FileAccess.Read)) {
                var person = (Person) binaryFormatter.Deserialize(loadStream) ;
                loadStream.Close();
                Console.WriteLine(person);
            }
        }

        private static void SerializePersonData() {
            var person = new Person { Name = "Karan", Age = 26, Married = true };
            IFormatter binaryFormatter = new BinaryFormatter();
            using (var saveStream = new FileStream("person.bin", FileMode.Create, FileAccess.Write)) {
                binaryFormatter.Serialize(saveStream, person);
                saveStream.Close();
            }
        }

        private static void DeserializeListOfPersonsData() {
            var binaryFormatter = new BinaryFormatter();
            using (var loadStream = new FileStream("persons.bin", FileMode.Open, FileAccess.Read)) {
                var persons = (Person[])binaryFormatter.Deserialize(loadStream);
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
            var binaryFormatter = new BinaryFormatter();
            using (var saveStream = new FileStream("persons.bin", FileMode.Create, FileAccess.Write)) {
                binaryFormatter.Serialize(saveStream, persons);
                saveStream.Close();
            }
        }
    }
}
