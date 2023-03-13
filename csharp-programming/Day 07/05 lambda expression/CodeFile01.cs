namespace training_basic_csharp {
    class Program {
        delegate int operation();
        static void Main() {
            // non-parametric lambda
            operation random = () => { Random r = new Random(); return r.Next(); };
            int result = random();
            result = random();
        }
    }
}

/*
 * General syntax of lambda function is:
 * ([parameter list]) => expression or
 * ([parameter list]) => {
 *  // code block
 *   return expression;
 * }
 * 
 * The parameter list is a comma-separated list of parameters that the function accepts,
 * which can include optional types. If the function takes no parameters, the parameter
 * list can be left empty.
 */

