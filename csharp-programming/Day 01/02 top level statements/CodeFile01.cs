int a = 1, b = 2, c = 0;
c = a + b;
Console.WriteLine("c = {0}", c);

/*
 * Starting in C# 9, you don't have to explicitly include a Main method in a console application project.
 * Instead, you can use the top-level statements feature to minimize the code you have to write.
 * In this case, the compiler generates a class and Main method entry point for the application.
 * A project can have only one file with top-level statements.
 * Putting top-level statements in more than one file in a project results in the following compiler error:
 * CS8802 Only one compilation unit can have top-level statements.
 */
