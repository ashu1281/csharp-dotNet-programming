using System;

namespace csharp_programming {
    [Serializable]
    public class Person {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Married { get; set; }

        public bool IsGraduate { get; set; }

        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}", Name, Age, Married, IsGraduate);
        }
    }
}
