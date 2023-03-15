using System;
using System.Runtime.Serialization;

namespace csharp_programming {
    [Serializable]
    public class Person : ISerializable {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Married { get; set; }

        public bool IsGraduate { get; set; }

        public Person() { }

        public Person(string Name, int Age, bool Married, bool IsGraduate) {
            this.Name = Name;
            this.Age = Age;
            this.Married = Married;
            this.IsGraduate = IsGraduate;
        }

        //used for deserialization
        public Person(SerializationInfo info, StreamingContext context) {
            Name = info.GetString("Name");
            Age = info.GetInt32("Age");
            Married = info.GetBoolean("Married");
            IsGraduate = info.GetBoolean("IsGraduate");
        }

        //used for serialization
        public void GetObjectData(SerializationInfo info, StreamingContext context) {
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Married", Married);
            info.AddValue("IsGraduate", IsGraduate);
        }

        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}", Name, Age, Married, IsGraduate);
        }
    }
}

/*
 * - What's the point in implementing ISerializable interface?
 *   - ISerializable is used to provide custom binary serialization,
 *     usually for BinaryFormatter (and perhaps for remoting purposes).
 * For more information on how to implement ISerializable refer to the following link:
 * https://learn.microsoft.com/en-us/visualstudio/code-quality/ca2240?view=vs-2022&tabs=csharp
 */ 