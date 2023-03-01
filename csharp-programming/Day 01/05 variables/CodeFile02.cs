namespace csharp_programming {
    class Program {
        static void Main() {
            int 1n;             // Invalid: A variable name shouldn't begin with a number.
            int _1n;            // Valid: A variable name can begin either with alphabet or _
            int n1;             // Valid: Subsequent characters after first, can be numbers or alphabets
            int emp code;       // Invalid: An identifier name shouldn't contain a white space
            int emp_code;       // Valid: '_' can be used to simulate presence of space
            double int;         // Invalid: A variable name cannot be a keyword
            int a, b, c;        // Valid: You can define multiple variables at a time.
            int d, e = 1, f;    // Valid: Initialization of variables is optional, however its a good practice to initialize every variable.
        }
    }
}

/*
 * Identifier Naming Rules:
 * It can begin with a letter or underscore.
 * Subsequent characters can be numerals.
 * It cannot be amongst C# keywords.
 * Avoid whitespace characters.
 * Use pascal case to name namespaces, classes, and public members of the classes.
 * Avoid snake case instead use mixed case for ex. avoid emp_salary use empSalary instead.
 * Avoid using all letters capital for naming constants.
 * Use camel casing to name private members, parameters etc.
 * Remember C# is case sensitive so empName and EmpName are two different variables.
 * Do not define two variables with the same name in the same scope.
 */
