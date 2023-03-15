using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

namespace csharp_programming {
    internal class Program {
        public static void Main(string[] args) {
            SerializePersonData();
            DeserializePersonData();
            SerializeListOfPersonsData();
            DeserializeListOfPersonsData();
        }

        private static void DeserializePersonData() {
            var jsonSerializer = new DataContractJsonSerializer(typeof(Person));
            using (var loadStream = new FileStream("person.json", FileMode.Open, FileAccess.Read)) {
                Person person = (Person)jsonSerializer.ReadObject(loadStream);
                loadStream.Close();
                Console.WriteLine(person);
            }
        }

        private static void SerializePersonData() {
            Person person = new Person { Name = "Karan", Age = 26, Married = true, IsGraduate = true };
            var jsonSerializer = new DataContractJsonSerializer(typeof(Person));
            using (var saveStream = new FileStream("person.json", FileMode.Create, FileAccess.Write)) {
                jsonSerializer.WriteObject(saveStream, person);
                saveStream.Close();
            }
        }

        private static void DeserializeListOfPersonsData() {
            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Person>));
            using (var loadStream = new FileStream("persons.json", FileMode.Open, FileAccess.Read)) {
                var persons = (List<Person>)jsonSerializer.ReadObject(loadStream);
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
            var jsonSerializer = new DataContractJsonSerializer(typeof(List<Person>));
            using (var saveStream = new FileStream("persons.json", FileMode.Create, FileAccess.Write)) {
                jsonSerializer.WriteObject(saveStream, persons);
                saveStream.Close();
            }
        }
    }
}

/*
 * For more demos refer to
 * - https://www.youtube.com/watch?v=dsMgjbJIthw for XML serialization using DataContractSerializer
 * - https://www.youtube.com/watch?v=NV2WRRcfkeU for JSON serialization using DataContractJsonSerializer
 */