namespace csharp_programming {
    partial class Integer {
        public static Integer operator +(Integer u, Integer v) {
            Integer result = new Integer { Value = 0 };
            result.Value = u.Value + v.Value;
            return result;
        }
    }
}