namespace csharp_programming {
    class Integer {
        public int Value { get; set; }
        public static Integer operator +(Integer u, Integer v) {//you have to overload as a static.
            Integer result = new Integer { Value = 0 };
            result.Value = u.Value + v.Value;
            return result;
        }
    }
    class Program {
        static void Main() {
            Integer i = new Integer { Value = 1 };
            Integer j = new Integer { Value = 2 };
            Integer k = null;
            k = i + j; // k=operator+(i, j);
        }
    }
}

/*
 * +, -, !, ~, ++, --, true, false      These unary operators can be overloaded.
 * 
 * +, -, *, /, %, &, |, ^, <<, >>       These binary operators can be overloaded.
 * 
 * ==, !=, <, >, <=, >=                 The comparison operators can be overloaded
 *                                      The comparison operators, if overloaded,
 *                                      must be overloaded in pairs; that is, 
 *                                      if == is overloaded, != must also be 
 *                                      overloaded. The reverse is also true,
 *                                      where overloading != requires an overload 
 *                                      for ==. The same is true for comparison 
 *                                      operators < and > and for <= and >=.
 *                                      
 * &&, ||                               The conditional logical operators cannot be
 *                                      overloaded, but they are evaluated
 *                                      using & and |, which can be overloaded.
 *                                      
 * []                                   The array indexing operator cannot be overloaded,
 *                                      but you can define indexers.
 *                                      
 * (T)x                                 The cast operator cannot be overloaded,
 *                                      but you can define new conversion operators.
 *                                      
 * +=, -=, *=, /=, %=, &=, |=, ^=,      Assignment operators cannot be overloaded,
 * <<=, >>= 	                        but +=, for example, is evaluated using +,
 *                                      which can be overloaded.
 *                                      
 * =, ., ?:, ??, ->, =>, f(x), as,      These operators cannot be overloaded.
 * checked, unchecked, default,
 * delegate, is, new, sizeof, 
 * typeof
 */
