using System;

namespace csharp_programming {
    [Serializable]
    public class Employee : Person {
        public string Designation { get; set; }

        public double CTC { get; set; }
    
        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}, Designation = {4}, CTC = {5}",
                Name, Age, Married, IsGraduate, Designation, CTC);
        }
    }
}
