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
            var xmlSerializer = new XmlSerializer(typeof(Employee));
            using (var loadStream = new FileStream("employee.xml", FileMode.Open, FileAccess.Read)) {
                Person employee = (Employee)xmlSerializer.Deserialize(loadStream);
                loadStream.Close();
                Console.WriteLine(employee);
            }
        }

        private static void SerializePersonData() {
            Employee employee = new Employee { Name = "Karan", Age = 26, Married = true, IsGraduate = true, Designation = "Developer", CTC = 400000 };
            var xmlSerializer = new XmlSerializer(typeof(Employee));
            using (var saveStream = new FileStream("employee.xml", FileMode.Create, FileAccess.Write)) {
                xmlSerializer.Serialize(saveStream, employee);
                saveStream.Close();
            }
        }

        private static void DeserializeListOfPersonsData() {
            var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            using (var loadStream = new FileStream("employees.xml", FileMode.Open, FileAccess.Read)) {
                var employees = (List<Employee>)xmlSerializer.Deserialize(loadStream);
                loadStream.Close();
                foreach (var employee in employees) {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void SerializeListOfPersonsData() {
            var employees = new List<Employee>{
                new Employee { Name = "Ratan", Age = 26, Married = true, IsGraduate = true, Designation = "Manager", CTC = 3000000 },
                new Employee { Name = "Rahul", Age = 27, Married = true, IsGraduate = false, Designation = "Team Lead", CTC = 1800000 },
                new Employee { Name = "Rohit", Age = 22, Married = false, IsGraduate = true, Designation = "Tester", CTC = 1500000 }
            };
            var xmlSerializer = new XmlSerializer(typeof(List<Employee>));
            using (var saveStream = new FileStream("employees.xml", FileMode.Create, FileAccess.Write)) {
                xmlSerializer.Serialize(saveStream, employees);
                saveStream.Close();
            }
        }
    }
}
