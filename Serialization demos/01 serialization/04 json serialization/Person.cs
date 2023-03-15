using System.Runtime.Serialization;

namespace csharp_programming {
    //[DataContract]
    public class Person {
        //[DataMember(Order = 0)]
        public string Name { get; set; }

        //[DataMember(Order = 1)]
        public int Age { get; set; }

        //[DataMember(Order = 2)]
        public bool Married { get; set; }

        //[DataMember(Order = 3)]
        public bool IsGraduate { get; set; }

        public override string ToString() {
            return string.Format("Name = {0}, Age = {1}, Married = {2}, Graduate = {3}", Name, Age, Married, IsGraduate);
        }
    }
}

/*
 * Note mentioning Order is optional.
 * Data members and properties are serialised in alphabetical order if Order is not specified.
 * The data member or property does not take part in serialisation if it is not decorated with [DataMember].
 */