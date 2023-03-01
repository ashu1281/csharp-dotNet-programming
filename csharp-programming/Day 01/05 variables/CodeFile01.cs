namespace csharp_programming {
    class Program {
        static void Main() {
            // explicit type variables
            int a; // uninitialized variable
            int b, c; // multiple uninitialized variables in same statement

            float f = 1.0f; // initialized variable
            double pi = 3.14, e = 4.803E-10; // multiple initialized variables in same statement

            string s; // unitialized string object
            s = "Hey! World"; // assignment

            // implicit type variables
            var u = "C#";
            u = "hellow world";
            var v = 38;
            var w = true;
            var x = 1, y = 3; //implicitly type defining not possible , you have to define var separatly for y variable.
        }
    }
}

/*
 * General syntax: datatype variable = initial-value;
 * Assignment is giving value to a variable later after its definition.
 */
