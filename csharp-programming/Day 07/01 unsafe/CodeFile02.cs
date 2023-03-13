namespace csharp_Programming
{
    class Program
    {
        public static void Main(string[] args) {
            unsafe
            {
                string s = "hello!";
                fixed(char* pc = s)
                {
                    *pc = 'H';
                    *(pc + 5)  = '?';
                }
            }
        }
    }
}

 /*
 *  The fixed keyword can be used to pin a managed object in memory
 *  and obtain a pointer to the object's memory location.
 *  The unsafe code can be written within an unsafe block or
 *  within the unsafe function itself. 
 */