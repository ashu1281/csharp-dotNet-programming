namespace csharp_programming {
    static class Algorithm {
        
        /// <summary>
        /// Returns the smaller of the given values. 
        /// </summary>
        /// <param name="a">The first number</param>
        /// <param name="b">The second number</param>
        /// <returns>The smaller of a and b. If the values are equivalent, returns b.</returns>
        public static int Min(int a, int b) {
            return a < b ? a : b;
        }
    }
}
