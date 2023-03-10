
namespace csharp_programming
{
    //internal class DummyBase //error: Abstract mehtod can not be a member of non-abstract class.
    internal abstract class DummyBase
    {
        public abstract void Print();
        //public abstract void Print() { } //error => Abstract method can not have body.

    }
}
